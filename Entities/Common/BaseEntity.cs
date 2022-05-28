using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public interface IEntity
	{

	}
	public abstract class BaseEntity<Tkey>:IEntity
	{
		public Tkey Id { get; set; }
	}
	//int 
	//GUID  => GLobal Unique Identifier 

	public class BaseEntity : BaseEntity<int>
	{

	}
}
