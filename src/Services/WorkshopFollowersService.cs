using System;
using Provider.Exceptions;
using Provider.Repositories;

namespace Provider.Services;

public class WorkshopFollowersService : IWorkshopFollowersService {

    private IWorkshopFollowersRepository _repository;

    public WorkshopFollowersService(IWorkshopFollowersRepository repository)
    {
        this._repository = repository;
    }

    public WorkshopFollower GetWorkshopFollower(Guid id)
    {
        WorkshopFollower found = _repository.GetWorkshopFollower(id);
        if (found != null) {
            return found;
        } else {
            throw new WorkshopFollowersException();
        }
    }

    public Guid SaveWorkshopFollower(WorkshopFollower workshopFollower) {
        try 
        {
            Guid id = _repository.SaveWorkshopFollower(workshopFollower);
            return id;
        } catch(Exception e)
        {
            Console.Write(e);
            throw new Exception("Failed to store workshopfollower");
        }
    }
}