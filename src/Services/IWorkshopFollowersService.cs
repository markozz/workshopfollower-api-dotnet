using System;

namespace Provider.Services;

public interface IWorkshopFollowersService 
{
    WorkshopFollower GetWorkshopFollower(Guid id);
     Guid SaveWorkshopFollower(WorkshopFollower workshopFollower);
}