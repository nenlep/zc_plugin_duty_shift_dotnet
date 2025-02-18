using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace App
{
    public class BulkWriteModel<TPayload>
    {
        [Required]
        public string plugin_id { get; set; }

        [Required]
        public string organization_id { get; set; }

        [Required]
        public string collection_name { get; set; }

        [Required]
        public bool bulk_write { get; set; }

        [Required]
        public IEnumerable<TPayload> payload { get; set; }
    }
}