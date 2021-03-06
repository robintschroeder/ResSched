// <auto-generated> - Template:ModelsBackedByDto, Version:1.1, Id:f1539c0d-024f-4b1f-b346-132cdd9dd31f
using CodeGenHero.Logging;
using CodeGenHero.DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using CodeGenHero.ResourceScheduler.API.Client.Interface;
using CodeGenHero.ResourceScheduler.Model.RS.Interface;
using xDTO = CodeGenHero.ResourceScheduler.DTO.RS;

namespace CodeGenHero.ResourceScheduler.Model.RS
{

	public class LoadRequestResourceSchedule : EventArgs
	{
		public LoadRequestResourceSchedule(string propertyNameRequestingLoad)
		{
			PropertyNameRequestingLoad = propertyNameRequestingLoad;
		}

		public string PropertyNameRequestingLoad { get; set; }
	}


	public partial class ResourceSchedule : BaseModel<IWebApiDataServiceRS>, IResourceSchedule
	{
		public event EventHandler<LoadRequestResourceSchedule> OnLazyLoadRequest = delegate { }; // Empty delegate. Thus we are sure that value is always != null because no one outside of the class can change it.
		private xDTO.ResourceSchedule _dto = null;

		public ResourceSchedule(ILoggingService log, IDataService<IWebApiDataServiceRS> dataService) : base(log, dataService)
		{
			_dto = new xDTO.ResourceSchedule();
			OnLazyLoadRequest += HandleLazyLoadRequest;
		}

		public ResourceSchedule(ILoggingService log, IDataService<IWebApiDataServiceRS> dataService, xDTO.ResourceSchedule dto) : this(log, dataService)
		{
			_dto = dto;
		}


		public virtual string CreatedBy { get { return _dto.CreatedBy; } }
		public virtual System.DateTime CreatedDate { get { return _dto.CreatedDate; } }
		public virtual System.Guid Id { get { return _dto.Id; } }
		public virtual bool IsDeleted { get { return _dto.IsDeleted; } }
		public virtual System.DateTime ReservationEndDateTime { get { return _dto.ReservationEndDateTime; } }
		public virtual string ReservationNotes { get { return _dto.ReservationNotes; } }
		public virtual System.DateTime ReservationStartDateTime { get { return _dto.ReservationStartDateTime; } }
		public virtual System.Guid? ReservedByUserId { get { return _dto.ReservedByUserId; } }
		public virtual string ReservedForUser { get { return _dto.ReservedForUser; } }
		public virtual System.DateTime ReservedOnDateTime { get { return _dto.ReservedOnDateTime; } }
		public virtual System.Guid ResourceId { get { return _dto.ResourceId; } }
		public virtual string UpdatedBy { get { return _dto.UpdatedBy; } }
		public virtual System.DateTime UpdatedDate { get { return _dto.UpdatedDate; } }

		private IResource _resource = null; // Foreign Key
		private IUser _user = null; // Foreign Key


		public virtual IResource Resource
		{
			get
			{
				if (_resource == null && _dto != null && _dto.Resource != null)
				{
					_resource = new Resource(Log, DataService, _dto.Resource);
				}

				return _resource;
			}
		}

		public virtual IUser User
		{
			get
			{
				if (_user == null && _dto != null && _dto.User != null)
				{
					_user = new User(Log, DataService, _dto.User);
				}

				return _user;
			}
		}



	}
}
