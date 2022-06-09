using Unite.Identity.Entities.Enums;

namespace Unite.Identity.Entities
{
	public class CandidatePermission
	{
		public int CandidateId { get; set; }
		public Permission PermissionId { get; set; }
		public string Restrictions { get; set; }

		public virtual Candidate Candidate { get; set; }
	}
}
