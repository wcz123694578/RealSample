using System;
using System.Collections.Generic;
using System.Text;
using RealSample.DAL.Abstractions;
using RealSample.DBUtilities;
using System.Data.Common;
using System.Data.SQLite;
using RealSample.Core.Models.ViewModels;
using RealSample.Core.Models.Queries;
using System.IO;
using RealSample.Shared;

namespace RealSample.DAL {
    public class MediaFileDataService : IMediaFileDataService {
        private readonly SqlHelper _sqlHelper;

        public MediaFileDataService() {
            _sqlHelper = SqlHelperFactory.GetDefault();
        }

        #region IMediaFileDataService 成员

        public int AddMediaFile(string filePath, string hash, int categoryId, DateTime createdAt, DateTime modifiedAt) {
            string sql = @"
INSERT INTO MediaFile (
    FilePath, 
    Hash, 
    CategoryId, 
    CreatedAt, 
    ModifiedAt
) 
VALUES (
    @FilePath, 
    @Hash, 
    @CategoryId, 
    @CreatedAt, 
    @ModifiedAt
);

SELECT last_insert_rowid();
            ";

            SQLiteParameter[] parameters = new SQLiteParameter[] {
                new SQLiteParameter("@FilePath", filePath),
                new SQLiteParameter("@Hash", hash),
                new SQLiteParameter("@CategoryId", categoryId),
                new SQLiteParameter("@CreatedAt", createdAt),
                new SQLiteParameter("@ModifiedAt", modifiedAt)
            };

            object result = _sqlHelper.ExecuteScalar(sql, System.Data.CommandType.Text, parameters);

            if (result != null && result != DBNull.Value) {
                return Convert.ToInt32(result);
            }

            return 0;
        }

        #endregion

        #region IMediaFileDataService 成员


        public IEnumerable<MediaFileMasterResult> SelectMediaFiles(MediaFileQuery query) {
            string directory = query.Directory;
            if (!string.IsNullOrEmpty(directory)) {
                string[] fileNames = Directory.GetFiles(query.Directory);
            }

            string querySql = @"
SELECT mf.Id        AS Id,
       mf.FilePath  AS FilePath,
       mf.CreatedAt AS CreatedAt,
       0            AS CategoryId,
       ''           AS CategoryName
FROM MediaFile mf;
            ";

            List<MediaFileMasterResult> results = new List<MediaFileMasterResult>();

            using (DbDataReader reader = _sqlHelper.ExecuteReader(querySql, System.Data.CommandType.Text)) {
                while (reader.Read()) {
                    MediaFileMasterResult result = new MediaFileMasterResult();

                    result.Id = Convert.ToInt32(reader["Id"]);
                    result.FilePath = reader["FilePath"].ToString();
                    result.CreatedAt = Convert.ToDateTime(reader["CreatedAt"]);
                    result.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                    result.CategoryName = reader["CategoryName"].ToString();

                    results.Add(result);
                }
            }

            return results;
        }

        #endregion

        #region IMediaFileDataService 成员


        public void DeleteMediaFile(int id) {
            string querySql = @"
DELETE
FROM MediaFile
WHERE Id = @MediaFileId;
";

            SQLiteParameter[] sqlParameters = new SQLiteParameter[] {
                new SQLiteParameter("@MediaFileId", id)
            };

            _sqlHelper.ExecuteNonQuery(querySql, System.Data.CommandType.Text, sqlParameters);
        }

        #endregion
    }
}
