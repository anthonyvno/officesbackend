using backend2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend2.Data
{
    public class OfficeContext: IEntityTypeConfiguration<Office>
    {
        private Guid[] _ids;

        public OfficeContext(Guid[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder
              .HasData(
                new Office
                {
                    Id = _ids[0],
                    Name = "Dunder Mifflin Ghent",
                    City = "Ghent",
                    Latitude = 51.043476,
                    Longitude = 3.709138,
                    Email = "ghent@dundermifflin.com"
                },
                new Office
                {
                    Id = _ids[1],
                    Name = "Dunder Mifflin Kortrijk",
                    City = "Kortrijk",
                    Latitude = 50.822956,
                    Longitude = 3.250962,
                    Email = "kortrijk@dundermifflin.com"
                }, new Office
                {
                    Id = _ids[2],
                    Name = "Dunder Mifflin Harelbeke",
                    City = "Harelbeke",
                    Latitude = 50.855366,
                    Longitude = 3.312553,
                    Email = "harelbeke@dundermifflin.com"
                }
            );
        }
    }
}
