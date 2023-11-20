using System;
using System.Collections.Generic;

namespace Provider.Repositories;
public class WorkshopFollowersRepository : IWorkshopFollowersRepository {
    private Dictionary<Guid, WorkshopFollower> _db;

    public WorkshopFollowersRepository()
    {
        this._db = new Dictionary<Guid, WorkshopFollower>();
    }

    public Guid SaveWorkshopFollower(WorkshopFollower workshopFollower)
    {
        Guid id = workshopFollower.id;
        Console.WriteLine(id);
        this._db.Add(id, workshopFollower);
        return id;
    }

    public WorkshopFollower GetWorkshopFollower(Guid id)
    {
        return this._db.GetValueOrDefault(id);
    }
}