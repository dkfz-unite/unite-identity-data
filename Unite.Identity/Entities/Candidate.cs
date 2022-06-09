using System.Collections.Generic;

namespace Unite.Identity.Entities
{
	public class Candidate
	{
		public int Id { get; set; }
		public string Email { get; set; }

		public virtual ICollection<CandidatePermission> CandidatePermissions { get; set; }
	}
}
