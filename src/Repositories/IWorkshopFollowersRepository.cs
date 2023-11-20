using System;

namespace Provider.Repositories;

public interface IWorkshopFollowersRepository
{
    Guid SaveWorkshopFollower(WorkshopFollower workshopFollower);
    WorkshopFollower GetWorkshopFollower(Guid id);
}