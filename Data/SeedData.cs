using Microsoft.EntityFrameworkCore;
using lab10.Data;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new ApplicationDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>());

        // Проверяем, есть ли уже данные
        if (context.Otdelenie.Any())
        {
            return; // База уже заполнена
        }

        // Добавляем отделения
        var otdeleniya = new[]
        {
            new Otdelenie { OtdelenieName = "Терапевтическое", HeadDoc = "Иванов А.С.", CountRoom = 5 },
            new Otdelenie { OtdelenieName = "Хирургическое", HeadDoc = "Петров В.И.", CountRoom = 4 },
            new Otdelenie { OtdelenieName = "Кардиологическое", HeadDoc = "Сидорова М.К.", CountRoom = 3 }
        };
        context.Otdelenie.AddRange(otdeleniya);
        context.SaveChanges();

        // Добавляем палаты
        var palaty = new[]
        {
            // Терапевтическое отделение
            new Palata { PalataNum = "101", CountBeds = 4, OtdelenieId = 1 },
            new Palata { PalataNum = "102", CountBeds = 4, OtdelenieId = 1 },
            new Palata { PalataNum = "103", CountBeds = 2, OtdelenieId = 1 },
            // Хирургическое отделение
            new Palata { PalataNum = "201", CountBeds = 2, OtdelenieId = 2 },
            new Palata { PalataNum = "202", CountBeds = 3, OtdelenieId = 2 },
            // Кардиологическое отделение
            new Palata { PalataNum = "301", CountBeds = 3, OtdelenieId = 3 },
            new Palata { PalataNum = "302", CountBeds = 2, OtdelenieId = 3 }
        };
        context.Palata.AddRange(palaty);
        context.SaveChanges();

        // Добавляем пациентов
        var patients = new[]
        {
            // Палата 101
            new Patient { PatientFirstName = "Анна", PatientLastName = "Смирнова", PatientMiddleName = "Петровна",
                         BirthDate = new DateTime(1985, 3, 15), Genger = "Женский", Diagnos = "Грипп", PalataId = 1 },
            new Patient { PatientFirstName = "Дмитрий", PatientLastName = "Васильев", PatientMiddleName = "Игоревич",
                         BirthDate = new DateTime(1978, 7, 22), Genger = "Мужской", Diagnos = "Бронхит", PalataId = 1 },
            // Палата 102
            new Patient { PatientFirstName = "Михаил", PatientLastName = "Попов", PatientMiddleName = "Александрович",
                         BirthDate = new DateTime(1965, 12, 10), Genger = "Мужской", Diagnos = "Пневмония", PalataId = 2 },
            // Палата 201
            new Patient { PatientFirstName = "Сергей", PatientLastName = "Новиков", PatientMiddleName = "Викторович",
                         BirthDate = new DateTime(1988, 9, 5), Genger = "Мужской", Diagnos = "Аппендицит", PalataId = 4 },
            // Палата 301
            new Patient { PatientFirstName = "Татьяна", PatientLastName = "Волкова", PatientMiddleName = "Ивановна",
                         BirthDate = new DateTime(1960, 4, 12), Genger = "Женский", Diagnos = "Гипертония", PalataId = 6 }
        };
        context.Patient.AddRange(patients);
        context.SaveChanges();
    }
}