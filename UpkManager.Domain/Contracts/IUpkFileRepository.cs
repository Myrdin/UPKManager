﻿using System.Collections.Generic;
using System.Threading.Tasks;

using UpkManager.Domain.Models;


namespace UpkManager.Domain.Contracts {

  public interface IUpkFileRepository {

    Task LoadDirectoryRecursiveFlat(List<DomainUpkFile> ParentFile, int Version, string ParentPath, string Path, string Filter);

    Task LoadDirectoryRecursive(DomainExportedObject Parent, string Path);

    Task<DomainHeader> LoadUpkFile(string Filename);

    Task SaveUpkFile(DomainHeader Header, string Filename);

    Task<int> GetGameVersion(string GamePath);

  }

}
