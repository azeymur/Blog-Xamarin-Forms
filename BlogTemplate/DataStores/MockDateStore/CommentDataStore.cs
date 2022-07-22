using System;
using System.Collections.Generic;
using BlogTemplate.Models;
using EcommerceTemplate.DataStores.MockDataStore;

namespace BlogTemplate.DataStores.MockDateStore
{
    /// <summary>
    /// Mock data store with fake entities to test.
    /// </summary>
    public class CommentDataStore : BaseDataStore<Comment>, ICommentDataStore
    {
        protected override IList<Comment> items { get; }

        public CommentDataStore()
        {
            items = new List<Comment>
            {
                // p001

                new Comment { Id = "cm001", UserId = "u002", PostId = "p001", DateGmt = new DateTime(2021, 1, 3),
                        Content = "Curabitur laoreet odio vitae nisl dapibus venenatis. Quisque semper nulla neque, at hendrerit orci consequat vel." },

                new Comment { Id = "cm002", UserId = "u001", PostId = "p001", DateGmt = new DateTime(2021, 1, 18),
                        Content = "Vivamus suscipit cursus ipsum, nec porta nunc varius vitae. Nullam tempus, metus ac scelerisque mollis, elit ligula lacinia erat, vel commodo diam odio ullamcorper augue. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas." },

                new Comment { Id = "cm003", UserId = "u002", PostId = "p001", DateGmt = new DateTime(2021, 2, 14),
                        Content = "Fusce venenatis, elit vitae cursus interdum, elit massa scelerisque lacus, nec ultricies sapien orci et enim. Duis quis vestibulum lorem, at placerat mi." },

                // p002

                new Comment { Id = "cm004", UserId = "u002", PostId = "p002", DateGmt = new DateTime(2021, 2, 9),
                        Content = "Donec mattis ac mauris eu cursus." },

                new Comment { Id = "cm005", UserId = "u001", PostId = "p002", DateGmt = new DateTime(2021, 4, 17),
                        Content = "Vivamus rutrum eget felis eu eleifend. Quisque nibh justo, rutrum eu turpis non, rutrum semper augue. Maecenas velit elit, malesuada a nibh at, eleifend sagittis orci." },

                new Comment { Id = "cm006", UserId = "u002", PostId = "p002", DateGmt = new DateTime(2021, 5, 22),
                        Content = "Vestibulum dictum, nisi et ullamcorper elementum, enim risus pulvinar eros, sed varius leo nulla eu nulla. Interdum et malesuada fames ac ante ipsum primis in faucibus. Phasellus sit amet accumsan lorem, ac consectetur est." },

                new Comment { Id = "cm007", UserId = "u002", PostId = "p002", DateGmt = new DateTime(2021, 6, 9),
                        Content = "Phasellus mi nisl, facilisis ac nibh eu, placerat tempus ligula. Quisque in metus ut ligula cursus facilisis eget sit amet nisl. Etiam vehicula venenatis dolor sed aliquam. Aenean pulvinar libero et nisi elementum gravida. Mauris maximus metus eget nisl lobortis, vitae tempus purus lobortis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus." },

                // p003

                new Comment { Id = "cm008", UserId = "u002", PostId = "p003", DateGmt = new DateTime(2021, 6, 10),
                        Content = "Nunc ac fringilla augue. Ut interdum aliquam aliquam." },

                new Comment { Id = "cm009", UserId = "u001", PostId = "p003", DateGmt = new DateTime(2021, 8, 25),
                        Content = "Nam est dui, porta a sapien vel, aliquet facilisis tortor. Sed vel porta est. Suspendisse pellentesque purus at tristique blandit. Sed mollis a tellus ut mollis. Nunc eros tortor, scelerisque ut lectus id, aliquam consequat odio." },

                // p004

                new Comment { Id = "cm010", UserId = "u002", PostId = "p004", DateGmt = new DateTime(2021, 3, 14),
                        Content = "Fusce ullamcorper ex diam, nec malesuada nisi elementum a. Aliquam dolor felis, elementum sed orci ac, mattis laoreet dolor. Proin lacinia, dolor vel ultricies consequat, quam dolor sagittis sem, id elementum eros metus vestibulum elit. Pellentesque quis dui sapien. Nulla dictum, neque in elementum cursus, turpis velit fringilla nisl, in luctus nibh arcu molestie eros." },

                new Comment { Id = "cm011", UserId = "u002", PostId = "p004", DateGmt = new DateTime(2021, 7, 2),
                        Content = "Ut tincidunt ex nec diam elementum, vel ultricies justo tincidunt. Morbi rhoncus hendrerit justo ac malesuada. Duis vestibulum, ligula in gravida egestas, mi ante rhoncus leo, in elementum quam quam ut ipsum. Interdum et malesuada fames ac ante ipsum primis in faucibus. Morbi urna justo, sodales nec lacinia eu, euismod sit amet ligula." },

                // p005

                new Comment { Id = "cm012", UserId = "u002", PostId = "p005", DateGmt = new DateTime(2021, 2, 9),
                        Content = "Aliquam mattis mattis semper. In ultrices eget nisi ac pharetra. Duis id nisl scelerisque urna vehicula molestie quis a arcu." },

                // p006

                new Comment { Id = "cm013", UserId = "u001", PostId = "p006", DateGmt = new DateTime(2021, 4, 6),
                        Content = "Donec lectus dui, pulvinar a vehicula vel, blandit sed purus." },

                new Comment { Id = "cm014", UserId = "u002", PostId = "p006", DateGmt = new DateTime(2021, 4, 9),
                        Content = "Pellentesque tincidunt semper purus, at porta nulla sodales quis. Morbi vitae erat arcu. " },

                // p007

                new Comment { Id = "cm015", UserId = "u002", PostId = "p007", DateGmt = new DateTime(2021, 1, 3),
                        Content = "Aliquam cursus enim eu hendrerit sodales. Vivamus luctus, tellus non tincidunt dapibus, mi neque ultricies ipsum, id venenatis ex arcu in lacus. In hac habitasse platea dictumst. Pellentesque lacus metus, ornare non feugiat vel, suscipit eget sapien. Duis convallis ornare odio non bibendum. Nunc hendrerit orci vel pharetra interdum." },

                new Comment { Id = "cm016", UserId = "u001", PostId = "p007", DateGmt = new DateTime(2021, 2, 8),
                        Content = "Duis aliquam massa augue, vitae sollicitudin massa laoreet at. Suspendisse iaculis nisi et urna scelerisque, a lobortis lorem venenatis. In vitae libero cursus, viverra eros in, hendrerit justo." },

                new Comment { Id = "cm017", UserId = "u002", PostId = "p007", DateGmt = new DateTime(2021, 6, 17),
                        Content = "Nunc suscipit orci ut sem mattis bibendum. Etiam viverra velit nec purus dictum, eget aliquam tellus posuere." },

                new Comment { Id = "cm018", UserId = "u002", PostId = "p007", DateGmt = new DateTime(2021, 7, 29),
                        Content = "Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus." },

                // p008

                new Comment { Id = "cm019", UserId = "u002", PostId = "p008", DateGmt = new DateTime(2021, 3, 7),
                        Content = "Donec nec tempus nibh, eu cursus purus. Suspendisse tortor mauris, condimentum eget condimentum ultrices, venenatis at tortor. Phasellus lacinia rhoncus iaculis. Aenean vitae mauris pretium, volutpat sapien vitae, tincidunt purus. Praesent molestie ante id sapien mollis, eget tincidunt risus volutpat. In placerat risus erat. Integer ornare interdum nulla, et rutrum ligula blandit eget. Suspendisse ultricies nec ipsum at laoreet. Suspendisse mollis turpis vel ex bibendum congue. Nunc mollis elit eget ultricies dignissim." },

                new Comment { Id = "cm020", UserId = "u001", PostId = "p008", DateGmt = new DateTime(2021, 4, 9),
                        Content = "Pellentesque mattis ullamcorper dui sit amet dictum. Aliquam et lobortis quam. Maecenas tincidunt ipsum eu cursus rhoncus." },

                // p009

                new Comment { Id = "cm021", UserId = "u002", PostId = "p009", DateGmt = new DateTime(2021, 4,21),
                        Content = "Nunc volutpat suscipit tortor eu pulvinar. Quisque bibendum molestie odio. Curabitur porta interdum est quis lacinia." },

                // p010

                new Comment { Id = "cm022", UserId = "u002", PostId = "p010", DateGmt = new DateTime(2021, 4, 12),
                        Content = "In vitae lacus laoreet, aliquet metus ut, vulputate tellus. Integer sed mi eu libero semper viverra. Morbi sollicitudin risus nec elit posuere, faucibus fringilla ex condimentum. Etiam mauris turpis, ullamcorper ac ipsum at, tincidunt consequat neque. Vivamus vulputate mi nec sem aliquet vestibulum." },

                new Comment { Id = "cm001", UserId = "u002", PostId = "p010", DateGmt = new DateTime(2021, 5, 15),
                        Content = "Duis efficitur dolor in enim interdum sodales." },

                new Comment { Id = "cm002", UserId = "u001", PostId = "p010", DateGmt = new DateTime(2021, 6, 27),
                        Content = "Sed faucibus ipsum eget magna tempus, eu vestibulum velit sagittis. Donec tincidunt pellentesque lorem quis molestie. Fusce elementum orci ut odio dictum, quis posuere tellus ullamcorper." },

                // p011

                new Comment { Id = "cm003", UserId = "u002", PostId = "p011", DateGmt = new DateTime(2021, 2, 21),
                        Content = "Suspendisse accumsan, tellus eu consequat ultrices, justo ex vulputate risus, id venenatis leo neque vel ipsum. Suspendisse velit ante, suscipit sit amet iaculis accumsan, posuere eget ex." },

                new Comment { Id = "cm004", UserId = "u002", PostId = "p011", DateGmt = new DateTime(2021, 3, 18),
                        Content = "Etiam malesuada ultricies euismod. Sed odio mauris, tempor quis dapibus vitae, rutrum non massa." },

                // p012

                new Comment { Id = "cm005", UserId = "u001", PostId = "p012", DateGmt = new DateTime(2021, 1, 25),
                        Content = "Maecenas laoreet, magna non congue fermentum, nisl risus varius nulla, et egestas urna ligula a diam. Nullam elementum ut nibh vel varius. Vivamus eros lectus, congue eget tellus in, aliquet sagittis leo. Praesent diam mauris, dapibus eu purus ut, dictum pretium odio. Sed ac aliquet sem." },

                new Comment { Id = "cm006", UserId = "u002", PostId = "p012", DateGmt = new DateTime(2021, 2, 14),
                        Content = "Vestibulum aliquam eros fringilla lectus scelerisque tincidunt. Phasellus vel pellentesque odio, at auctor augue. In hac habitasse platea dictumst." },

                new Comment { Id = "cm007", UserId = "u002", PostId = "p012", DateGmt = new DateTime(2021, 4, 27),
                        Content = "Curabitur at nisi vitae eros mattis imperdiet. Sed enim metus, sodales vel suscipit in, facilisis eget nulla. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Morbi lacinia sodales ex. Cras auctor sapien risus, egestas fringilla dolor finibus vitae. Pellentesque eu turpis non velit venenatis consequat a non eros." },

                // p013

                new Comment { Id = "cm008", UserId = "u002", PostId = "p013", DateGmt = new DateTime(2021, 2, 9),
                        Content = "Ut in est vitae nibh imperdiet eleifend. In hendrerit placerat dignissim. Mauris eleifend augue eget risus accumsan sodales. Proin posuere justo a metus mattis sagittis. Quisque vel bibendum metus. Integer ac ipsum venenatis, posuere turpis eu, aliquet magna. Nullam nec nisl auctor, efficitur est ut, gravida diam. Praesent auctor, sem sit amet sagittis tincidunt, leo nulla cursus sem, semper tempor urna sem pellentesque odio." },

                new Comment { Id = "cm009", UserId = "u001", PostId = "p013", DateGmt = new DateTime(2021, 5, 18),
                        Content = "Proin dictum sem justo, quis ultricies ante iaculis et. Maecenas rutrum tempus tellus ut vestibulum. Suspendisse imperdiet imperdiet odio, a ornare ligula feugiat egestas." },

                // p014

                new Comment { Id = "cm010", UserId = "u002", PostId = "p014", DateGmt = new DateTime(2021, 6, 3),
                        Content = "Quisque mollis semper eros non hendrerit. Curabitur non lacus dolor. Aenean sit amet urna sed erat dapibus gravida et et justo." },

                new Comment { Id = "cm011", UserId = "u002", PostId = "p014", DateGmt = new DateTime(2021, 8, 19),
                        Content = "Nunc venenatis, ante ac fermentum luctus, ligula ligula semper enim, quis commodo mi erat ac massa. Donec ornare arcu a tortor commodo mattis. Phasellus a justo id purus ornare iaculis." },

                // p015

                new Comment { Id = "cm012", UserId = "u002", PostId = "p015", DateGmt = new DateTime(2021, 4, 6),
                        Content = "Vestibulum et laoreet ipsum, at scelerisque velit. Suspendisse quis ipsum quam. Pellentesque in ligula mi. Mauris eget accumsan turpis. Mauris ultrices sollicitudin ultrices." },

                // p016

                new Comment { Id = "cm013", UserId = "u001", PostId = "p016", DateGmt = new DateTime(2021, 5, 29),
                        Content = "Etiam imperdiet neque in urna ullamcorper, eu tincidunt risus vestibulum. Integer aliquet at eros ut posuere. Suspendisse gravida, ante non aliquet venenatis, ex urna sodales leo, quis fermentum metus purus sed nunc." },

                new Comment { Id = "cm014", UserId = "u002", PostId = "p016", DateGmt = new DateTime(2021, 6, 13),
                        Content = "Integer sagittis, sem varius gravida semper, est neque lacinia nisl, sit amet sagittis nisi mauris nec neque. Mauris efficitur sed nisl vitae aliquet." },

                // p017

                new Comment { Id = "cm015", UserId = "u002", PostId = "p017", DateGmt = new DateTime(2021, 2, 16),
                        Content = "Nulla eu neque at purus tempus rhoncus. Praesent eget pellentesque turpis." },

                new Comment { Id = "cm016", UserId = "u001", PostId = "p017", DateGmt = new DateTime(2021, 4, 23),
                        Content = "Nunc ac congue risus, a pellentesque lorem. Aliquam vel dignissim diam, et ultricies est. Cras vulputate est ut libero ornare suscipit." },

                new Comment { Id = "cm017", UserId = "u002", PostId = "p017", DateGmt = new DateTime(2021, 4, 24),
                        Content = "Morbi scelerisque non tortor nec ultricies. Curabitur quis facilisis nunc, non imperdiet enim. Vivamus vehicula urna mauris, bibendum lacinia eros congue eu." },

                new Comment { Id = "cm018", UserId = "u002", PostId = "p017", DateGmt = new DateTime(2021, 5, 4),
                        Content = "In vestibulum magna vel aliquam auctor. Etiam varius eros eget lorem porttitor pharetra. Nunc nec felis felis. Curabitur ut ante sit amet lorem posuere semper in vitae elit." },

                // p018

                new Comment { Id = "cm019", UserId = "u002", PostId = "p018", DateGmt = new DateTime(2021, 5, 11),
                        Content = "Integer luctus ante sem, id semper nisi aliquam faucibus. Fusce a nibh sapien." },

                new Comment { Id = "cm020", UserId = "u001", PostId = "p018", DateGmt = new DateTime(2021, 7, 18),
                        Content = "Donec lectus ante, gravida ac velit eu, vestibulum luctus metus. Duis eleifend eleifend augue eu lobortis. Aenean ligula velit, dignissim nec rutrum quis, egestas fringilla tellus." },

                // p019

                new Comment { Id = "cm021", UserId = "u002", PostId = "p019", DateGmt = new DateTime(2021, 3, 20),
                        Content = "Sed diam ante, laoreet eu ultrices eu, hendrerit sed ex. Morbi bibendum fringilla nibh luctus aliquam. Nam sit amet ligula non nulla suscipit elementum sit amet vitae nisl. Nulla ornare convallis venenatis. Vivamus dictum sapien id diam scelerisque convallis. In eu nisi in lacus egestas feugiat." },

                // p020

                new Comment { Id = "cm022", UserId = "u002", PostId = "p020", DateGmt = new DateTime(2021, 5, 31),
                        Content = "Nullam lacinia auctor arcu quis congue. Proin eget urna a risus convallis ullamcorper. Pellentesque venenatis, sapien malesuada blandit posuere, velit nisi faucibus augue, vel faucibus nulla lectus maximus ex." },

                // p021

                new Comment { Id = "cm023", UserId = "u002", PostId = "p021", DateGmt = new DateTime(2021, 1, 30),
                        Content = "Maecenas sit amet ante nisi. Vestibulum tristique in dolor eget accumsan. Nullam nisi orci, auctor vitae hendrerit non, scelerisque vulputate ante. Curabitur tempus turpis et est dignissim, eget vulputate eros convallis." },

                new Comment { Id = "cm024", UserId = "u002", PostId = "p021", DateGmt = new DateTime(2021, 1, 31),
                        Content = "Curabitur sed enim quis felis lobortis posuere. " },

                new Comment { Id = "cm025", UserId = "u001", PostId = "p021", DateGmt = new DateTime(2021, 4, 14),
                        Content = "Aliquam non semper enim. Ut a porttitor tellus, id dapibus risus. Vestibulum sed mauris dictum, luctus est et, elementum augue. Donec blandit consectetur tellus ac tempus. Ut imperdiet, sem vitae mattis viverra, augue nisl sollicitudin ligula, posuere finibus lectus mi et ex. Sed dignissim sem at pulvinar porttitor." },

                new Comment { Id = "cm026", UserId = "u002", PostId = "p021", DateGmt = new DateTime(2021, 5, 9),
                        Content = "Donec imperdiet elit nulla, vel pharetra erat malesuada quis. Cras ultricies vulputate rutrum. Aliquam erat volutpat. Ut sit amet molestie odio. Etiam vel neque risus. Nam vel libero vel lacus congue suscipit ac at erat" },

                // p022

                new Comment { Id = "cm027", UserId = "u002", PostId = "p022", DateGmt = new DateTime(2021, 3, 29),
                        Content = "Donec porttitor, neque sit amet sagittis aliquet, ipsum odio porttitor magna, finibus sagittis nisl libero at dolor. Curabitur maximus, ipsum vel finibus dictum, sem leo lobortis erat, vitae vulputate nisl lacus vel sem. Aenean lorem neque, efficitur at erat vitae, varius rhoncus mi. Aliquam id ullamcorper nibh. Suspendisse quam turpis, pellentesque et blandit non, pellentesque eu libero." },

                new Comment { Id = "cm028", UserId = "u002", PostId = "p022", DateGmt = new DateTime(2021, 6, 18),
                        Content = "Nam quis suscipit enim. Suspendisse accumsan congue placerat. Aliquam erat volutpat. Quisque fermentum scelerisque dictum. Proin semper urna erat, sit amet semper est blandit non." },

                // p023

                new Comment { Id = "cm029", UserId = "u001", PostId = "p023", DateGmt = new DateTime(2021, 2, 20),
                        Content = "Cras imperdiet vitae mi sit amet varius. Nam ac ultricies nisi. Donec sed orci aliquam, blandit lectus non, blandit lectus. Sed fermentum porttitor ligula non condimentum." },

                // p024

                new Comment { Id = "cm030", UserId = "u002", PostId = "p024", DateGmt = new DateTime(2021, 1, 13),
                        Content = "Ut eget odio vitae justo auctor tincidunt molestie et lacus. Phasellus vestibulum malesuada ullamcorper." },

                new Comment { Id = "cm031", UserId = "u002", PostId = "p024", DateGmt = new DateTime(2021, 4, 30),
                        Content = "Praesent sit amet faucibus enim. Donec vestibulum non felis sed bibendum." },

                // p025

                new Comment { Id = "cm032", UserId = "u002", PostId = "p025", DateGmt = new DateTime(2021, 2, 9),
                        Content = "Etiam facilisis leo id ante vestibulum, sit amet fringilla turpis eleifend. Integer efficitur commodo erat id tempor" },

                new Comment { Id = "cm033", UserId = "u001", PostId = "p025", DateGmt = new DateTime(2021, 3, 1),
                        Content = "Curabitur vel eros vitae dolor eleifend imperdiet." },

                new Comment { Id = "cm034", UserId = "u002", PostId = "p025", DateGmt = new DateTime(2021, 5, 18),
                        Content = "Nulla ut congue odio, ac volutpat odio. Ut efficitur mauris urna, nec sollicitudin nulla viverra nec. Praesent ut suscipit erat. Etiam sodales fermentum est, eu tincidunt libero. In orci quam, sagittis ac mattis at, suscipit vel ex." },

                // p026

                new Comment { Id = "cm035", UserId = "u002", PostId = "p026", DateGmt = new DateTime(2021, 1, 2),
                        Content = "Nulla maximus urna at ex dictum posuere. Etiam elit quam, convallis non dolor vitae, feugiat vulputate est." },

                new Comment { Id = "cm036", UserId = "u001", PostId = "p026", DateGmt = new DateTime(2021, 3, 19),
                        Content = "Vestibulum viverra fringilla dolor, sed sollicitudin orci tempus id. Praesent eu feugiat arcu." },

                new Comment { Id = "cm037", UserId = "u002", PostId = "p026", DateGmt = new DateTime(2021, 5, 11),
                        Content = "Aenean facilisis mi felis, sed bibendum felis volutpat at. Maecenas bibendum nisl sed blandit dictum." },

                new Comment { Id = "cm038", UserId = "u002", PostId = "p026", DateGmt = new DateTime(2021, 6, 28),
                        Content = "Nulla gravida, orci et porttitor tincidunt, neque ipsum gravida odio, at tempus neque augue ut metus. Curabitur pellentesque, nisl elementum fermentum euismod, purus diam cursus ante, sed mollis enim erat in mi. Aenean vitae rhoncus ipsum. Fusce quis lacus non lacus dictum aliquet." },

                // p027

                new Comment { Id = "cm039", UserId = "u002", PostId = "p027", DateGmt = new DateTime(2021, 3, 19),
                        Content = "Integer sit amet ultricies sapien, lobortis faucibus ligula." },

                new Comment { Id = "cm040", UserId = "u001", PostId = "p027", DateGmt = new DateTime(2021, 5, 29),
                        Content = "Vestibulum vel nunc et mi accumsan convallis sit amet et augue." },

                // p028

                new Comment { Id = "cm041", UserId = "u002", PostId = "p028", DateGmt = new DateTime(2021, 4, 10),
                        Content = "In blandit mauris sed tempor porta. In suscipit faucibus vulputate. Sed quam magna, vulputate aliquet quam tempus, volutpat aliquet quam. Fusce cursus libero sed diam condimentum aliquam. Duis vel dolor enim. Nam scelerisque nulla vitae augue feugiat consequat. Cras tellus quam, tincidunt vel justo at, lobortis elementum diam. Mauris in ultrices est, placerat egestas augue. Mauris et risus mauris. Suspendisse vehicula, justo rutrum congue feugiat, nisl nisi sollicitudin nulla, ultricies rutrum sapien nisi at ligula." },

                new Comment { Id = "cm042", UserId = "u002", PostId = "p028", DateGmt = new DateTime(2021, 6, 9),
                        Content = "Donec quis risus justo. Morbi mauris libero, tempus sollicitudin mi eget, scelerisque porttitor nunc. Sed condimentum enim at egestas volutpat." },

            };
        }
    }
}
