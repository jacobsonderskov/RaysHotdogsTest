using System;
using RaysHotDogs.Core.Model;
using System.Collections.Generic;

namespace RaysHotDogs.Core.Repository
{
	public interface IHotDogRepository
	{
		List<HotDog> GetAllHotDogs();

		List<HotDogGroup> GetGroupedHotDogs();

		List<HotDog> GetHotDogsForGroup (int hotDogGroupId);

		List<HotDog> GetFavoriteHotDogs ();

		HotDog GetHotDogById (int hotDogId);
	}
}

