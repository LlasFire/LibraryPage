using DataLayer.DAL;
using System.Linq;
using DataLayer.Library;

namespace DataLayer
{
    public static class SampleData
    {
        public static void InitData(RegistrationContext context)
        {
            if(!context.Genres.Any())
            {
                context.Genres.Add(new Genre()
                {
                    Name = "Fantasy",
                    Description = "A Book under this genre contains a story set in " +
                                  "a fantasy world – a world that is not real and often " +
                                  "includes magic, magical creatures, and supernatural events."
                });

                context.Genres.Add(new Genre()
                {
                    Name = "Horror",
                    Description = "Horror is a genre that is intended to or has " +
                                   "the ability to create the feeling of fear, repulsion, " +
                                   "fright or terror in the readers. In other words, it creates " +
                                   "a frightening and horror atmosphere."
                });

                context.Genres.Add(new Genre()
                {
                    Name = "Science Fiction",
                    Description = "Science Fiction typically deals with imaginative " +
                                   "and futuristic concepts such as advanced science and " +
                                   "technology, time travel, extraterrestrial life, etc. " +
                                   "The stories are often set in the future or on other planets."
                });

                context.Genres.Add(new Genre()
                {
                    Name = "Historical Fiction",
                    Description = "Historical fiction is a genre of book that includes writings that " +
                                  "reconstruct the past. The story is set in the past keeping the manners, " +
                                  "social conditions and other details of that period unchanged. The writers " +
                                  "incorporate the past events or people in their fictitious stories."
                });

                context.Genres.Add(new Genre()
                {
                    Name = "Fairy tale",
                    Description = "Fairy tale is usually a story for children that involves imaginary " +
                                  "creatures and magical events."
                });

                context.Genres.Add(new Genre()
                {
                    Name = "Mystery",
                    Description = "Mystery books have a suspenseful plot that often involves a mysterious crime. " +
                                  "Suspects and motives are considered and clues throughout the story lead to a solution " +
                                  "to the problem."
                });

                context.Genres.Add(new Genre()
                {
                    Name = "Adventure",
                    Description = "The stories under this genre usually show an event or a series of events " +
                                  "that happen outside the course of the protagonist’s ordinary life. " +
                                  "The plot is mostly accompanied by danger and physical action. " +
                                  "These stories almost always move quickly and the high pace of the plot is usually " +
                                  "an important part of the story."
                });

                context.Genres.Add(new Genre()
                {
                    Name = "Detective",
                    Description = "As the name suggests, this book genre deals with crime, criminal motives and " +
                                  "the investigation and detection of the crime and criminals."
                });

                context.Genres.Add(new Genre()
                {
                    Name = "Humor",
                    Description = "Humor fiction is usually full of fun, fancy, and excitement. " +
                                  "It is meant to entertain and sometimes cause intended laughter in readers."
                });

                context.SaveChanges();
            }

            if (!context.Authors.Any())
            {
                context.Authors.Add(new Author()
                {
                    FirstName = "John",
                    LastName = "Tolkien",
                    Biography = "English writer, poet, philologist, and academic, who is best known as the author of the classic high fantasy works The Hobbit, " +
                                "The Lord of the Rings, and The Silmarillion."
                });

                context.Authors.Add(new Author()
                {
                    FirstName = "Arthur",
                    LastName = "Doyle",
                    Biography = "British writer best known for his detective fiction featuring the character Sherlock Holmes. Originally a physician, " +
                                "in 1887 he published A Study in Scarlet, the first of four novels and more than fifty short stories about Holmes and Dr. Watson."
                });

                context.Authors.Add(new Author()
                {
                    FirstName = "Wilhelm",
                    LastName = "Grimm",
                    Biography = "German author and anthropologist, and the younger brother of Jacob Grimm, of the library duo the Brothers Grimm."
                });

                context.Authors.Add(new Author()
                {
                    FirstName = "Stephen",
                    LastName = "King",
                    Biography = "American author of horror, supernatural fiction, suspense, science fiction, and fantasy novels. " +
                                "His books have sold more than 350 million copies, many of which have been adapted into feature films, " +
                                "miniseries, television series, and comic books."
                });

                context.Authors.Add(new Author()
                {
                    FirstName = "Jerome",
                    LastName = "Jerome",
                    Biography = "English writer and humorist, best known for the comic travelogue Three Men in a Boat. Other works include " +
                                "the essay collections Idle Thoughts of an Idle Fellow and Second Thoughts of an Idle Fellow; Three Men on the Bummel, " +
                                "a sequel to Three Men in a Boat, and several other novels."
                });

                context.Authors.Add(new Author()
                {
                    FirstName = "Suzanne",
                    LastName = "Collins",
                    Biography = "American television writer and author. She is known as the author of The New York Times best-selling series " +
                                "The Underland Chronicles and The Hunger Games trilogy."
                });

                context.Authors.Add(new Author()
                {
                    FirstName = "Charles",
                    LastName = "Dickens",
                    Biography = "English writer and social critic. He created some of the world's best-known fictional characters " +
                                "and is regarded by many as the greatest novelist of the Victorian era. His works enjoyed unprecedented popularity during his lifetime, " +
                                "and by the 20th century critics and scholars had recognised him as a literary genius."
                });

                context.Authors.Add(new Author()
                {
                    FirstName = "Daniel",
                    LastName = "Brown",
                    Biography = "American author best known for his thriller novels, including the Robert Langdon novels Angels & Demons, The Da Vinci Code, " +
                                "The Lost Symbol, Inferno and Origin. His novels are treasure hunts that usually take place over a period of 24 hours."
                });

                context.SaveChanges();
            }

            if (!context.Books.Any())
            {
                context.Books.Add(new Book()
                {
                    Name = "The Hobbit",
                    Description = "The story is told in the form of an episodic quest, and most chapters introduce a specific creature or type of creature of Tolkien's geography. " +
                                  "Bilbo gains a new level of maturity, competence, and wisdom by accepting the disreputable, romantic, fey, " +
                                  "and adventurous sides of his nature and applying his wits and common sense. The story reaches its climax " +
                                  "in the Battle of the Five Armies, where many of the characters and creatures from earlier chapters re-emerge to engage in conflict.",
                    NumberOfPages = 315,
                    AuthorId = context.Authors.First<Author>(a => a.FirstName == "John" && a.LastName == "Tolkien").AuthorId,
                    GenreId = context.Genres.First<Genre>(a => a.Name == "Adventure").GenreId
                });

                context.Books.Add(new Book()
                {
                    Name = "Sherlock Holmes",
                    Description = "He is fictional private detective created by British author Sir Arthur Conan Doyle. Referring to himself as a 'consulting detective' " +
                                  "in the stories, Holmes is known for his proficiency with observation, forensic science, and logical reasoning that borders on the fantastic, " +
                                  "which he employs when investigating cases for a wide variety of clients, including Scotland Yard.",
                    NumberOfPages = 210,
                    AuthorId = context.Authors.First<Author>(a => a.FirstName == "Arthur" && a.LastName == "Doyle").AuthorId,
                    GenreId = context.Genres.First<Genre>(a => a.Name == "Detective").GenreId
                });

                context.Books.Add(new Book()
                {
                    Name = "Hansel and Gretel",
                    Description = "Hansel and Gretel are the children of a poor woodcutter. When a famine settles over the land, the woodcutter's wife (stepmother to Hansel and Gretel) " +
                                  "decides to take the children into the woods and leave them there to fend for themselves so she and her husband will not starve to death. " +
                                  "The woodcutter opposes the plan but finally reluctantly submits to his wife's scheme, unaware that Hansel and Gretel have overheard them. " +
                                  "After the parents have gone to bed, Hansel sneaks out of the house and gathers as many white pebbles as he can, then returns to his room, " +
                                  "reassuring Gretel that God will not forsake them.",
                    NumberOfPages = 40,
                    AuthorId = context.Authors.First<Author>(a => a.FirstName == "Wilhelm" && a.LastName == "Grimm").AuthorId,
                    GenreId = context.Genres.First<Genre>(a => a.Name == "Fairy tale").GenreId
                });

                context.Books.Add(new Book()
                {
                    Name = "The Lord of The Rings",
                    Description = "The title of the novel refers to the story's main antagonist, the Dark Lord Sauron, who had in an earlier age created the One Ring " +
                                  "to rule the other Rings of Power as the ultimate weapon in his campaign to conquer and rule all of Middle-earth. From quiet beginnings in the Shire, " +
                                  "a hobbit land not unlike the English countryside, the story ranges across Middle-earth, following the course of the War of the Ring through the eyes of its characters, " +
                                  "not only the hobbits Frodo Baggins, Samwise 'Sam' Gamgee, Meriadoc 'Merry' Brandybuck and Peregrin 'Pippin' Took, but also the hobbits' chief allies " +
                                  "and travelling companions: the Men, Aragorn, a Ranger of the North, and Boromir, a Captain of Gondor; Gimli, a Dwarf warrior; Legolas, an Elven prince; and Gandalf, a wizard.",
                    NumberOfPages = 2570,
                    AuthorId = context.Authors.First<Author>(a => a.FirstName == "John" && a.LastName == "Tolkien").AuthorId,
                    GenreId = context.Genres.First<Genre>(a => a.Name == "Fantasy").GenreId
                });

                context.Books.Add(new Book()
                {
                    Name = "The Shining",
                    Description = "The Shining centers on the life of Jack Torrance, an aspiring writer and recovering alcoholic who accepts a position as the off-season caretaker of the historic Overlook Hotel " +
                                  "in the Colorado Rockies. His family accompanies him on this job, including his young son Danny Torrance, who possesses 'the shining', an array of psychic abilities that allow Danny to see " +
                                  "the hotel's horrific past. Soon, after a winter storm leaves them snowbound, the supernatural forces inhabiting the hotel influence Jack's sanity, leaving his wife and son in incredible danger.",
                    NumberOfPages = 180,
                    AuthorId = context.Authors.First<Author>(a => a.FirstName == "Stephen" && a.LastName == "King").AuthorId,
                    GenreId = context.Genres.First<Genre>(a => a.Name == "Horror").GenreId
                });

                context.Books.Add(new Book()
                {
                    Name = "Three Men in a Boat",
                    Description = "Three Men in a Boat (To Say Nothing of the Dog) is a humorous account by English writer Jerome K. Jerome of a two-week boating holiday on the Thames from Kingston upon Thames to Oxford " +
                                  "and back to Kingston. The book was initially intended to be a serious travel guide, with accounts of local history along the route, but the humorous elements took over to the point where " +
                                  "the serious and somewhat sentimental passages seem a distraction to the comic novel.",
                    NumberOfPages = 216,
                    AuthorId = context.Authors.First<Author>(a => a.FirstName == "Jerome" && a.LastName == "Jerome").AuthorId,
                    GenreId = context.Genres.First<Genre>(a => a.Name == "Humor").GenreId
                });

                context.Books.Add(new Book()
                {
                    Name = "The Hunger Games",
                    Description = "The Hunger Games universe is a dystopia set in Panem, a North American country consisting of the wealthy Capitol and 12 districts in varying states of poverty. " +
                                  "Every year, children from the districts are selected via lottery to participate in a compulsory televised battle royale death match called The Hunger Games.",
                    NumberOfPages = 648,
                    AuthorId = context.Authors.First<Author>(a => a.FirstName == "Suzanne" && a.LastName == "Collins").AuthorId,
                    GenreId = context.Genres.First<Genre>(a => a.Name == "Science Fiction").GenreId
                });

                context.Books.Add(new Book()
                {
                    Name = "A Tale of Two Cities",
                    Description = "A Tale of Two Cities (1859) is a historical novel by Charles Dickens, set in London and Paris before and during the French Revolution. The novel tells the story " +
                                  "of the French Doctor Manette, his 18-year-long imprisonment in the Bastille in Paris and his release to live in London with his daughter Lucie, whom he had never met. " +
                                  "The story is set against the conditions that led up to the French Revolution and the Reign of Terror.",
                    NumberOfPages = 314,
                    AuthorId = context.Authors.First<Author>(a => a.FirstName == "Charles" && a.LastName == "Dickens").AuthorId,
                    GenreId = context.Genres.First<Genre>(a => a.Name == "Historical Fiction").GenreId
                });

                context.Books.Add(new Book()
                {
                    Name = "The Da Vinci Code",
                    Description = "The novel explores an alternative religious history, whose central plot point is that the Merovingian kings of France were descended from the bloodline of Jesus Christ " +
                                  "and Mary Magdalene, ideas derived from Clive Prince's The Templar Revelation (1997) and books by Margaret Starbird.",
                    NumberOfPages = 314,
                    AuthorId = context.Authors.First<Author>(a => a.FirstName == "Daniel" && a.LastName == "Brown").AuthorId,
                    GenreId = context.Genres.First<Genre>(a => a.Name == "Mystery").GenreId
                });

                context.SaveChanges();
            }

        }
    }
}
