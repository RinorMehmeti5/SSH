using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cunsult.DataAcess.Migrations
{
    /// <inheritdoc />
    public partial class FillDatabase1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Lendet",
                columns: new[] { "Lid", "DepartamentId", "Lname", "UserId", "VitiID" },
                values: new object[,]
                {
                    { 100, 10, "Algjebra lineare dhe kalkulus 1", null, 1 },
                    { 101, 10, "Fizika 1", null, null },
                    { 102, 10, "Bazat e inxhinierise elektrike 1", null, 1 },
                    { 103, 10, "Bazat e Programimit", null, 1 },
                    { 104, 10, "Anglishtja teknike", null, 1 },
                    { 105, 10, "Shkathtësi komunikuese", null, 1 },
                    { 106, 10, "Gjuhe gjermane", null, 1 },
                    { 107, 10, "Praktikum në matematikë", null, 1 },
                    { 108, 10, "Kalkulus 2", null, 1 },
                    { 109, 10, "Fizika 2", null, 1 },
                    { 110, 10, "Bazat e inxhinierisë elektrike 2", null, 1 },
                    { 111, 10, "Algoritmet dhe strukturat e të dhënave", null, 1 },
                    { 112, 10, "Qarqet digjitale", null, 1 },
                    { 113, 10, "Matematika diskrete dhe probabiliteti", null, 2 },
                    { 114, 10, "Bazat e të dhënave", null, 2 },
                    { 115, 10, "Programimi i orientuar në objekte", null, 2 },
                    { 116, 10, "Arkitektura e kompjuterëve", null, 2 },
                    { 117, 10, "Elektronika", null, 2 },
                    { 118, 10, "Programimi në ueb I", null, 2 },
                    { 119, 10, "Sistemet operative", null, 2 },
                    { 120, 10, "Inxhinieria softuerike", null, 2 },
                    { 121, 10, "Siguria e të dhënave", null, 2 },
                    { 122, 10, "Komunikimi njeri-kompjuter", null, 2 },
                    { 123, 10, "Programimi në ueb II", null, 2 },
                    { 124, 10, "Çeshtjet legale, etike dhe sociale ne TIK", null, 2 },
                    { 125, 10, "Buxheti dhe analiza e shpenzimeve", null, 2 },
                    { 126, 10, "Mikroprocesorët dhe mikrokontrollerët", null, 3 },
                    { 127, 10, "Dizajni dhe analiza e algoritmeve", null, 3 },
                    { 128, 10, "Rrjetat kompjuterike", null, 3 },
                    { 129, 10, "Programimi per pajisje mobile", null, 3 },
                    { 130, 10, "Inxhinierimi i të dhënave", null, 3 },
                    { 131, 10, "Siguria në kompjuter", null, 3 },
                    { 132, 10, "Testimi i softuerit", null, 3 },
                    { 133, 10, "Concurrent Computing", null, 3 },
                    { 134, 10, "Ndërmarresi dhe inovacion", null, 3 },
                    { 135, 10, "Menaxhimi i projekteve në TI", null, 3 },
                    { 137, 10, "Sistemet e shpërndara", null, 3 },
                    { 138, 10, "Gërmimi i të dhënave", null, 3 },
                    { 139, 10, "Siguria në internet", null, 3 },
                    { 140, 10, "Big data", null, 3 },
                    { 141, 10, "Nxjerrja e informatave", null, 3 },
                    { 142, 10, "Visual computing", null, 3 },
                    { 143, 10, "Cloud computing", null, 3 },
                    { 144, 10, "Parallel computing", null, 3 },
                    { 145, 10, "Komunikimi i të dhënave", null, 3 },
                    { 146, 10, "Biomedical Engineering", null, 3 },
                    { 147, 10, "Biometrics & Forensics", null, 3 },
                    { 148, 10, "Praktika profesionale", null, 3 },
                    { 149, 10, "Punimi i diplomës", null, 3 },
                    { 150, 11, "Algjebra lineare dhe kalkulus 1", null, 1 },
                    { 151, 11, "Fizika 1", null, 1 },
                    { 152, 11, "Bazat e inxhinierisë elektrike 1", null, 1 },
                    { 153, 11, "Bazat e Programimit", null, 1 },
                    { 154, 11, "Anglishtja teknike", null, 1 },
                    { 155, 11, "Shkathtësi komunikuese", null, 1 },
                    { 156, 11, "Gjuhe gjermane", null, 1 },
                    { 157, 11, "Praktikum në matematikë", null, 1 },
                    { 158, 11, "Kalkulus 2", null, 1 },
                    { 159, 11, "Fizika 2", null, 1 },
                    { 160, 11, "Bazat e inxhinierisë elektrike 2", null, 1 },
                    { 161, 11, "Algoritmet dhe strukturat e të dhënave", null, 1 },
                    { 162, 11, "Qarqet digjitale", null, 1 },
                    { 163, 11, "Mikroprocesorët dhe mikrokontrollerët", null, 2 },
                    { 164, 11, "Kalkulus 3E", null, 2 },
                    { 165, 11, "Sinjale dhe sisteme", null, 2 },
                    { 166, 11, "Automatika", null, 2 },
                    { 167, 11, "Elektronika", null, 2 },
                    { 168, 11, "Matjet elektronike", null, 2 },
                    { 169, 11, "Interneti i gjërave", null, 2 },
                    { 170, 11, "Elektroenergjetika", null, 2 },
                    { 171, 11, "Fushat dhe valët elektromagnetike", null, 2 },
                    { 172, 11, "Sinjalet diskrete dhe pёrpunimi digjital", null, 2 },
                    { 173, 11, "Arkitektura e kompjuterёve", null, 2 },
                    { 174, 11, "Inovacioni dhe biznesi", null, 2 },
                    { 175, 11, "Menaxhimi i projekteve", null, 2 },
                    { 176, 11, "Komponentët elektronike", null, 3 },
                    { 177, 11, "Elektronika digjitale", null, 3 },
                    { 178, 11, "Elektronika energjetike", null, 3 },
                    { 179, 11, "Optoelektronika", null, 3 },
                    { 180, 11, "Sensorët dhe aktuatorët", null, 3 },
                    { 181, 11, "Komunikimet elektronike", null, 3 },
                    { 182, 11, "Instrumentacioni matës dhe DAQ", null, 3 },
                    { 183, 11, "Bazat e mekatronikës", null, 3 },
                    { 184, 11, "Sinjalet biomedicinale", null, 3 },
                    { 185, 11, "Ndёrmarrёsia", null, 3 },
                    { 186, 11, "Mikroekonomia", null, 3 },
                    { 187, 11, "Mikroelektronika", null, 3 },
                    { 188, 11, "Elektronika analoge", null, 3 },
                    { 189, 11, "Bazat e multimedias", null, 3 },
                    { 190, 11, "Bazat e robotikës", null, 3 },
                    { 191, 11, "Teknologjia e komunikimeve optike", null, 3 },
                    { 192, 11, "Sistemet e ndërthurura ", null, 3 },
                    { 193, 11, "Projektimi i sistemeve elektronike me", null, 3 },
                    { 194, 11, "Instrumentacioni biomedicinale", null, 3 },
                    { 195, 11, "Praktika profesionale", null, 3 },
                    { 196, 11, "Tema e diplomës bachelor", null, 3 },
                    { 197, 11, "Sistemet e rregullimit automatik", null, 3 },
                    { 198, 11, "Bazat e robotikës", null, 3 },
                    { 199, 11, "Dirigjuesit e programueshëm logjik ", null, 3 },
                    { 200, 11, "Aktuatorët e mençur dhe ngasjet", null, 3 },
                    { 201, 11, "Sensorët e mençur", null, 3 },
                    { 202, 11, "Komunikimet në automatikë", null, 3 },
                    { 203, 11, "Metodat e elementeve tё fundme", null, 3 },
                    { 204, 11, "Sistemet operative", null, 3 },
                    { 205, 11, "Modelimi dhe simulimi", null, 3 },
                    { 206, 11, "Sistemet digjitale tё rregullimit", null, 3 },
                    { 207, 11, "Sistemet jolineare të rregullimit", null, 3 },
                    { 208, 11, "Rregullimi i proceseve kimike", null, 3 },
                    { 209, 11, "Proceset e vazhduara dhe grupore", null, 3 },
                    { 210, 11, "Rregullimi në kohë reale", null, 3 },
                    { 211, 11, "Grumbullimi kompjuterik i të dhënave", null, 3 },
                    { 212, 11, "Automatizimi i objekteve të banimit", null, 3 },
                    { 213, 11, "Praktika profesionale", null, 3 },
                    { 214, 11, "Tema e diplomës bachelor", null, 3 },
                    { 215, 12, "Algjebra lineare dhe kalkulus 1", null, 1 },
                    { 216, 12, "Fizika 1", null, 1 },
                    { 217, 12, "Bazat e inxhinierisë elektrike 1 ", null, 1 },
                    { 218, 12, "Bazat e Programimit", null, 1 },
                    { 219, 12, "Anglishtja teknike", null, 1 },
                    { 220, 12, "Shkathtësi komunikuese", null, 1 },
                    { 221, 12, "Gjuhe gjermane", null, 1 },
                    { 222, 12, "Praktikum në matematikë", null, 1 },
                    { 223, 12, "Kalkulus 2", null, 1 },
                    { 224, 12, "Fizika 2", null, 1 },
                    { 225, 12, "Bazat e inxhinierisë elektrike 2", null, 1 },
                    { 226, 12, "Algoritmet dhe strukturat e të dhënave", null, 1 },
                    { 227, 12, "Qarqet digjitale", null, 1 },
                    { 228, 12, "Kalkulus 3 dhe probabilitet", null, 2 },
                    { 229, 12, "Sinjalet dhe Informacionet", null, 2 },
                    { 230, 12, "Elektronikë", null, 2 },
                    { 231, 12, "Teknologjitë e Internetit", null, 2 },
                    { 232, 12, "Praktikum në Matlab", null, 2 },
                    { 233, 12, "Praktikum në Labview", null, 2 },
                    { 234, 12, "Komunikimet digjitale", null, 2 },
                    { 235, 12, "Valët elektromagnetike", null, 2 },
                    { 236, 12, "Transmetimi i të dhënave", null, 2 },
                    { 237, 12, "Menaxhimi i projekteve ne TIK", null, 2 },
                    { 238, 12, "Ekonomia per Inxhinieri", null, 2 },
                    { 239, 12, "Arkitektura e kompjutereve dhe pajisjeve", null, 2 },
                    { 240, 12, "Zhvillimi i aplikacioneve ne C++", null, 2 },
                    { 241, 12, "Zhvillimi i Web aplikacioneve/www", null, 2 },
                    { 242, 12, "Rrjetet komunikuese I", null, 3 },
                    { 243, 12, "Sistemet operative për TIK", null, 3 },
                    { 244, 12, "Programimi i orientuar ne objekte", null, 3 },
                    { 245, 12, "Teknologjitë dhe sistemet multimediale", null, 3 },
                    { 246, 12, "Python", null, 3 },
                    { 247, 12, "Zhvillimi aplikacioneve per Android dhe IOS", null, 3 },
                    { 248, 12, "Zhvillim i lojerave kompjuterike", null, 3 },
                    { 249, 12, "Praktikum në Matlab", null, 3 },
                    { 250, 12, "Praktikum në Labview", null, 3 },
                    { 251, 12, "Inxhinieria e RF dhe Mikrovalëve", null, 3 },
                    { 252, 12, "Komunikimet mobile", null, 3 },
                    { 253, 12, "Programimi i distribuar", null, 3 },
                    { 254, 12, "Rrjetet komunikuese II", null, 3 },
                    { 255, 12, "Projekti përfundimtar (Praktika profesionale dhe prezantimi)", null, 3 },
                    { 256, 12, "Komunikimet optike", null, 3 },
                    { 257, 12, "Bioelektromagnetika", null, 3 },
                    { 258, 12, "Protokolet komunikuese", null, 3 },
                    { 259, 12, "Animimi dhe VR", null, 3 },
                    { 260, 13, "Algjebra lineare dhe kalkulus 1", null, 1 },
                    { 261, 13, "Fizika 1", null, 1 },
                    { 262, 13, "Bazat e inxhinierisë elektrike 1", null, 1 },
                    { 263, 13, "Bazat e Programimit", null, 1 },
                    { 264, 13, "Anglishtja teknike", null, 1 },
                    { 265, 13, "Shkathtësi komunikuese", null, 1 },
                    { 266, 13, "Gjuhe gjermane", null, 1 },
                    { 267, 13, "Praktikum në matematikë", null, 1 },
                    { 268, 13, "Kalkulus 2", null, 1 },
                    { 269, 13, "Fizika 2", null, 1 },
                    { 270, 13, "Bazat e inxhinierisë elektrike 2", null, 1 },
                    { 271, 13, "Algoritmet dhe strukturat e të dhënave", null, 1 },
                    { 272, 13, "Qarqet digjitale", null, 1 },
                    { 273, 13, "Kalkulus 3 dhe probabilitet", null, 2 },
                    { 274, 13, "Materialet elektrike", null, 2 },
                    { 275, 13, "Matjet Elektrike", null, 2 },
                    { 276, 13, "Bazat e Elektroenergjetikës", null, 2 },
                    { 277, 13, "Elektronika", null, 2 },
                    { 278, 13, "Bazat e automatikës", null, 2 },
                    { 279, 13, "Sinjalet dhe sistemet", null, 2 },
                    { 280, 13, "Programimi i orientuar në objekte", null, 2 },
                    { 281, 13, "Aplikacionet softwerike në elektroenergjetikë", null, 2 },
                    { 282, 13, "Makinat elektrike dhe transformatorët", null, 2 },
                    { 283, 13, "Energjia dhe mjedisi", null, 2 },
                    { 284, 13, "Centralet elektrike", null, 2 },
                    { 285, 13, "Fushat dhe valët elektromagnetike", null, 2 },
                    { 286, 13, "Menaxhimi i energjisë dhe auditimi i efiçiencës", null, 2 },
                    { 287, 13, "Instrumentacioni matës në elektroenergjetikë", null, 2 },
                    { 288, 13, "Teknika e sigurimit në impiantet elektrike", null, 2 },
                    { 289, 13, "Transmetimi i të dhënave", null, 2 },
                    { 290, 13, "Tregu i energjisë elektrike", null, 3 },
                    { 291, 13, "Bartja dhe shpërndarja e energjisë elektrike", null, 3 },
                    { 292, 13, "Stabilimentet elektroenergjetike", null, 3 },
                    { 293, 13, "Instalimet elektrike dhe rrjetat e tensionit", null, 3 },
                    { 294, 13, "Burimet e ripërtëritshme të energjisë", null, 3 },
                    { 295, 13, "Energjia diellore dhe fotovoltaikët", null, 3 },
                    { 296, 13, "Elektronika energjetike", null, 3 },
                    { 297, 13, "Makinat elektrike speciale", null, 3 },
                    { 298, 13, "Rrjetat elektrike të fuqisë", null, 3 },
                    { 299, 13, "Energjia diellore dhe fotovoltaikët", null, 3 },
                    { 300, 13, "Ngasjet elektrike", null, 3 },
                    { 301, 13, "Mbrojtja e sistemeve elektroenergjetike", null, 3 },
                    { 302, 13, "Praktika profesionale", null, 3 },
                    { 303, 13, "Punimi i Diplomës", null, 3 },
                    { 304, 13, "Kualiteti i fuqisë në sistemet elektroenergjetike", null, 3 },
                    { 305, 13, "Energjia e erës", null, 3 },
                    { 306, 13, "Bazat e rrjetave të mençura", null, 3 },
                    { 307, 13, "Vlerësimi ekonomik i investimeve", null, 3 },
                    { 308, 13, "Menaxhimi i projekteve dhe etika", null, 3 },
                    { 309, 13, "Ndërmarrësia", null, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 309);
        }
    }
}
