using Supervision.CommonModel.Services;
using SupervisionApp.CommonModel.Models.OrganizationStructure;
using System;
using System.Collections.Generic;

namespace SupervisionApp.EF.Services.Mocks
{
    public class MockPostService : MockDataService<Post>, IPostService
    {
        public MockPostService()
        {
            Items = new List<Post>()
            {
                new Post() { Id = 1, CreationDate = DateTime.Now, Name = "Ведущий инженер"},
                new Post() { Id = 1, CreationDate = DateTime.Now, Name = "Инженер по ТН"},
                new Post() { Id = 1, CreationDate = DateTime.Now, Name = "Диспетчер"},
            };
        }
    }
}
