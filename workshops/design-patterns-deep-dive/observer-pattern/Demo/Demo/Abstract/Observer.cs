﻿namespace Demo.Abstract
{
    /// <summary>
    ///  This is the abstract class which will be inherited by oberservers.
    /// </summary>
    public abstract class Observer
    {
        public abstract void Update(int numberOfVehiclesReadyToShip);
    }
}
