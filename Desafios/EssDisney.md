# Deu a Louca no Disney+

Loki, cansado de pregar peças na TVA, roubou um artefato mágico da Wanda e sem querer abriu portais entre todos os mundos do Disney+!  
De repente:

- **The Mandalorian** apareceu em **Encanto**, confundindo **Casita** com uma nave viva.  
- **Simba** virou conselheiro real de **Aladdin** em Agrabah.  
- **Bela e a Fera** passaram a morar na mesma casa da família **Madrigal** — e a Casita adorou o novo hóspede peludo.  
- **Grogu** fugiu montado num tapete voador, espalhando caos enquanto mastigava flores mágicas.  
- **Wanda** tentava organizar tudo com feitiços... mas acabava transformando tapetes em camelos e camelos em gelatinas gigantes.

Para tentar organizar esse multiverso doidão, **Disney+ precisa de você**! Eis a sua missão:

---

## 📥 Entrada:

A primeira linha da entrada contém um único inteiro `N` (`1 ≤ N ≤ 1000`), indicando a quantidade de produções Disney+.  
A seguir, virão `N` linhas contendo, cada uma, diversas informações separadas por ponto e vírgula (`;`).  
Você deve ler e organizar em memória essas informações de acordo com o seguinte layout:

| Campo         | Tipo de Dado |
|---------------|---------------|
| `show_id`     | string        |
| `type`        | string        |
| `title`       | string        |
| `director`    | string        |
| `cast`        | string        |
| `country`     | string        |
| `date_added`  | string        |
| `release_year`| int           |
| `rating`      | string        |
| `duration`    | string        |
| `listed_in`   | string        |
| `description` | string        |

Em seguida, virão `C` linhas contendo comandos para organizar esses dados no formato:

Onde `[comando]` pode ser:

- `push`
- `pop`
- `queue`
- `dequeue`

E `[parâmetro]` pode ser **numérico** ou **string**.

### Regras:
- Para os comandos `push` e `queue`:
  - Se o parâmetro for **numérico**, todos os registros cujo **Ano (`release_year`)** seja igual ao valor devem ser adicionados à estrutura correspondente.
  - Caso contrário, deve-se considerar o campo **`type`** (tipo de produção) como critério de seleção.

---

## 📤 Saída:

A saída será gerada pelos comandos `pop` e `dequeue`.

- Se o parâmetro for **numérico**, devem ser removidos da estrutura e **impressos** a **quantidade de registros** indicada por esse valor.
- Caso o parâmetro seja a palavra **`all`**, todos os elementos da estrutura devem ser retirados e impressos.

> ✅ **Importante**: Ao imprimir os registros, deve-se fazer **apenas uma modificação** em relação à entrada:  
> O campo `date_added` deverá ser convertido para o formato **dd/mm/aaaa**.

## 📘 Exemplo de Entrada

```txt
32
s1;Movie;A Spark Story;Jason Sterman, Leanne Dare;Apthon Corbin, Louis Gonzales;;September 24, 2021;2021;TV-PG;88 min;Documentary;Two Pixar filmmakers strive to bring their uniquely personal SparkShorts visions to the screen.
s2;Movie;Spooky Buddies;Robert Vince;Tucker Albrizzi, Diedrich Bader, Ameko Eks Mass Carroll, Max Charles, Tim Conway, Jennifer Elise Cox;United States, Canada;September 24, 2021;2011;G;93 min;Comedy, Fantasy, Kids;The puppies go on a spooky adventure through a mysterious haunted mansion in this fur-raising flick.
s3;Movie;The Fault in Our Stars;Josh Boone;Shailene Woodley, Ansel Elgort, Laura Dern, Sam Trammell, Nat Wolff, Willem Dafoe;United States;September 24, 2021;2014;PG-13;127 min;Coming of Age, Drama, Romance;Hazel and Gus share a love that sweeps them on an unforgettable journey.
s4;TV_Show;Dog: Impossible;;Matt Beisner;United States;September 22, 2021;2019;TV-PG;2 Seasons;Animals & Nature, Docuseries, Family;Matt Beisner uses unique approaches to modifying canine behavior and focuses on each animal's needs.
s5;TV_Show;Spidey And His Amazing Friends;;Benjamin Valic, Lily Sanfelippo, Jakari Fraser, Dee Bradley Baker, Melanie Minichino;United States;September 22, 2021;2021;TV-Y;1 Season;Action-Adventure, Animation, Kids;Spidey teams up with pals to become The Spidey Team!
s6;TV_Show;Star Wars: Visions;;;;September 22, 2021;2021;TV-PG;1 Season;Action-Adventure, Animation, Anime;An animated anthology celebrating Star Wars through the lens of the world's best anime creators.
s7;Movie;Confessions of a Shopaholic;P.J. Hogan;Isla Fisher, Hugh Dancy, Joan Cusack, John Goodman, John Lithgow, Kristin Scott Thomas;United States;September 17, 2021;2009;PG;106 min;Comedy, Romance, Romantic Comedy;Becky writes a personal finance column en route to a high-fashion mag job.
s8;Movie;Descendants: Royal Wedding;Salvador Simó;Dove Cameron, Sofia Carson, Booboo Stewart, Mitchell Hope, Sarah Jeffery, Melanie Paxson;;September 17, 2021;2021;TV-G;22 min;Animation, Fantasy, Musical;Mal and Ben's wedding is finally here!
s9;Movie;Disney's Broadway Hits at London's Royal Albert Hall;Jay Hatcher;John Barrowman, Ashley Brown, Merle Dandridge, Trevor Dion Nicholas, Jade Ewen, Alton Fitzgerald White;;September 17, 2021;2016;TV-G;116 min;Concert Film;Experience the magic of Disney on Broadway in an unforgettable night of music.
s10;Movie;Flooded Tombs of the Nile;Katie Bauer Murdock;Devin E. Haqq;;September 17, 2021;2021;TV-PG;44 min;Documentary;Archaeologists dive into a pyramid flooded by the Nile to search for a king's burial.
s11;Movie;Jade Eyed Leopard;;Jeremy Irons;;September 17, 2021;2020;TV-PG;44 min;Animals & Nature, Documentary;Jade Eyed Leopard follows a leopard, Toto, throughout the first three years of her life.
s12;Movie;Nona;Louis Gonzales;;;September 17, 2021;2021;G;9 min;Animation, Comedy, Family;A grandmother's plan for a day alone is upended by an unexpected visit from her granddaughter.
s13;Movie;Smoky Mountain Park Rangers;;Peter Jessop;;September 17, 2021;2021;TV-PG;42 min;Documentary;Park Rangers protect the wildlife in Great Smoky Mountain National Park.
s14;TV_Show;Life Below Zero;;Chip Hailstone, Agnes Hailstone, Sue Aikens, Andy Bassich;United States;September 15, 2021;2012;TV-14;16 Seasons;Action-Adventure, Animals & Nature, Docuseries;Experience life deep in Alaska where the primal way lives on – brave the wild, fight the freeze.
s15;TV_Show;Miraculous: Tales Of Ladybug & Cat Noir;;Cristina Vee, Bryce Papenbrook, Keith Silverstein, Mela Lee, Max Mittelman, Carrie Keranen;France, South Korea, Japan, United States;September 15, 2021;2015;TV-Y7;1 Season;Action-Adventure, Animation, Fantasy;Superheroes Ladybug and Cat Noir protect the city.
s16;TV_Show;Ready for Preschool;;;;September 15, 2021;2019;TV-Y;1 Season;Kids, Music;The love of learning begins with Disney Junior!
s17;TV_Show;Unknown Waters with Jeremy Wade;;Jeremy Wade;;September 15, 2021;2021;TV-14;1 Season;Animals & Nature, Docuseries;Angler and adventurer, Jeremy Wade, explores the greatest river system in the world.
s18;Movie;Far Away From Raven's Home;;Raven-Symoné, Issac Ryan Brown, Navia Robinson, Jason Maybaum, Sky Katz, Anneliese van der Pol;;September 10, 2021;2021;TV-G;11 min;Comedy;Our gang is off for an exotic vacation of a lifetime!
s19;Movie;Pirates of the Caribbean: On Stranger Tides;Rob Marshall;Johnny Depp, Penélope Cruz, Ian McShane, Geoffrey Rush, Kevin R. McNally, Sam Claflin;United States, United Kingdom;September 10, 2021;2011;PG-13;140 min;Action-Adventure, Fantasy;A woman from his past uses Jack to help find the fabled Fountain of Youth.
s20;Movie;Twenty Something;Aphton Corbin;Kaylin Price, Ariana Brown, Aliyah Taylor, Janelle LaSalle, Napoleon Highbrou;United States;September 10, 2021;2021;PG;11 min;Animation, Family;Adulting is hard. One day you're nailing it, the next you're a stack of kids hiding in a trenchcoat.
s21;TV_Show;Doogie Kamealoha, M.D.;;Peyton Elizabeth Lee, Emma Meisel, Matthew Sato, Wes Tian, Jeffrey Bowyer-Chapman, Mapuana Makia;United States;September 8, 2021;2021;TV-PG;1 Season;Comedy, Coming of Age, Family;A 16-year-old prodigy juggles her budding medical career with the daily challenges of teenage life.
s22;TV_Show;Mira, Royal Detective;;Leela Ladnier, Utkarsh Ambudkar, Roshni Edwards, Kal Penn, Kamran Lucas;United States;September 8, 2021;2020;TV-Y;2 Seasons;Animation, Fantasy, Kids;Mira is the new royal detective in the land of Jalpur!
s23;TV_Show;Pepper Ann;;Kathleen Wilhoite, Clea Lewis, Danny Cooksey, Pamela Segall, April Winchell, Don Adams;United States;September 8, 2021;1997;TV-Y;3 Seasons;Animation, Comedy, Coming of Age;Pepper Ann Pearson is a teenage girl on an eternal quest for coolness.
s24;TV_Show;The Incredible Dr. Pol;;Rick Robles, Dr. Pol;United States;September 8, 2021;2011;TV-14;19 Seasons;Animals & Nature, Docuseries, Family;Dr. Pol and his team handle challenging veterinary cases and animal emergencies in central Michigan.
s25;Movie;Happier Than Ever: A Love Letter to Los Angeles;Robert Rodriguez, Patrick Osborne;Billie Eilish, FINNEAS;United States;September 3, 2021;2021;TV-14;66 min;Concert Film, Music;Billie Eilish makes her Disney+ debut with Happier Than Ever: A Love Letter to Los Angeles.
s26;Movie;Tomorrowland;Brad Bird;George Clooney, Hugh Laurie, Britt Robertson, Raffey Cassidy, Tim McGraw, Kathryn Hahn;United States, Spain, France, Canada, United Kingdom;September 3, 2021;2015;PG;131 min;Action-Adventure, Science Fiction;A jaded genius and an optimistic teen unearth the secrets of Tomorrowland.
s27;Movie;X-Men: Dark Phoenix;Simon Kinberg;James McAvoy, Michael Fassbender, Jennifer Lawrence, Nicholas Hoult, Sophie Turner, Tye Sheridan;United States, Canada;September 3, 2021;2019;PG-13;115 min;Action-Adventure, Family, Science Fiction;When Jean Grey transforms into the Dark Phoenix, the X-Men unite to face their greatest enemy yet.
s28;TV_Show;Alaska Animal Rescue;;Victoria Vosburg;United States;September 1, 2021;2019;TV-PG;2 Seasons;Animals & Nature, Docuseries, Family;Conservation heroes rescue and rehabilitate the wild animals of America's last frontier.
s29;TV_Show;Dug Days;;Bob Peterson, Ed Asner, Jordan Nagai;United States;September 1, 2021;2021;TV-PG;1 Season;Animation, Comedy, Family;"Dug Days" is a collection of shorts that follows the adventures of Dug, the dog from Pixar's "Up."
s30;Movie;Cruella;Craig Gillespie;Emma Stone, Emma Thompson, Joel Fry, Paul Walter Hauser, Emily Beecham, Kirby Howell-Baptiste;United States, United Kingdom;August 27, 2021;2021;PG-13;137 min;Crime, Drama;Witness the origin of Disney's most notorious and notoriously fashionable villain, Cruella de Vil.
s31;Movie;Dan in Real Life;Peter Hedges;Steve Carell, Juliette Binoche, Dane Cook, John Mahoney, Emily Blunt, Alison Pill;United States;August 27, 2021;2007;PG-13;99 min;Comedy, Drama, Romance;A relationship expert falls in love with his brother's new girlfriend.
s32;Movie;Disney Princess Remixed - An Ultimate Princess Celebration;Napoleon Dumo;Txunamy Oriz, Natalie Peyser, Dara Reneé, Frankie Rodriguez, Julia Lester, Ruth Righi;;August 27, 2021;2021;TV-G;22 min;Family, Music, Variety;Celebrate the timeless music of Disney Princess!
8
push 2021
pop 3
queue Movie
dequeue 3
queue 2016
push TV_Show
pop all
dequeue all


