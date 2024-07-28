﻿using Domain.Models;

namespace Application.Repositories;

public interface ISectionRepository
{
    Task<Section> AddAsync(Section section, CancellationToken cancellationToken = default);

    Task<Album> AddAlbumAsync(string sectionId, Album album, CancellationToken cancellationToken = default);

    Task<List<Section>> ToList(CancellationToken cancellationToken = default);
}