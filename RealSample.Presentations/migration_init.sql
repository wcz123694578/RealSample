-- =====================================
-- Table: Category
-- =====================================
CREATE TABLE IF NOT EXISTS Category (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL,
    ParentId INTEGER DEFAULT 0,
    CreatedAt DATETIME DEFAULT (datetime('now','localtime')),
    ModifiedAt DATETIME DEFAULT (datetime('now','localtime'))
);

-- =====================================
-- Table: MediaFile
-- =====================================
CREATE TABLE IF NOT EXISTS MediaFile (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    FilePath TEXT NOT NULL,
    Hash TEXT NOT NULL,
    CategoryId INTEGER NOT NULL,
    CreatedAt DATETIME DEFAULT (datetime('now','localtime')),
    ModifiedAt DATETIME DEFAULT (datetime('now','localtime')),
    FOREIGN KEY(CategoryId) REFERENCES Category(Id) ON DELETE CASCADE
);

-- =====================================
-- Table: CandidatePlugin
-- =====================================
CREATE TABLE IF NOT EXISTS CandidatePlugin (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    CatalogId INTEGER NOT NULL,
    PluginUniqueId TEXT NOT NULL,
    CreatedAt DATETIME DEFAULT (datetime('now','localtime')),
    ModifiedAt DATETIME DEFAULT (datetime('now','localtime'))
);