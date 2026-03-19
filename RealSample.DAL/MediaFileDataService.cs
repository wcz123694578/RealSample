using System;
using System.Collections.Generic;
using System.Text;
using RealSample.DAL.Abstractions;
using RealSample.DBUtilities;
using System.Data.Common;
using System.Data.SQLite;

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


        public IEnumerable<RealSample.Core.Models.MediaFile> SelectMediaFiles()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
