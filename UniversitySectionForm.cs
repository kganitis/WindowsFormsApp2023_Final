﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2023_Final
{
    public partial class UniversitySectionForm : WindowsFormsApp2023_Final.GuideSectionForm
    {
     
        public UniversitySectionForm()
        {
            InitializeComponent();

            section = new GuideSection("Πανεπιστήμιο");

            GuideSection subsection;

            subsection = new GuideSection("Ιστορικη Αναδρομή");
            section.AddSubsection(subsection);

            subsection = new GuideSection("Εγκαταστάσεις");
            section.AddSubsection(subsection);

            subsection = new GuideSection("Στρατηγική Πανεπιστημίου");
            section.AddSubsection(subsection);

            subsection = new GuideSection("Events");
            section.AddSubsection(subsection);

            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            NavButton1_Click(this, null);
        }
       
        

        protected override void NavButton2_Click(object sender, EventArgs e)
        {
            //label1.Text = "Ιστορική Αναδρομή";

            //pictureBox1.ImageLocation = "..\\..\\Resources\\unipi_old.png";
            //pictureBox2.ImageLocation = "..\\..\\Resources\\unipi_grounds.png";
            
            /*//label2.Text = "    Το Πανεπιστήμιο Πειραιώς ιδρύθηκε ως «Σχολή Βιομηχανικών Σπουδών» το 1938 από το Σύνδεσμο Βιομηχάνων και Βιοτεχνών," +
                " σύμφωνα με το Ν.5197/1931 και τον Α.Ν. 28/1936, που σε συνεργασία με το Σύνδεσμο Ανωνύμων Εταιριών της Ελλάδας" +
                " έβαλαν ως βάσεις την οικονομική, νομική και τεχνική παιδεία των στελεχών της βιομηχανίας.\r\n\r\n " +
                "   Το 1945 μετονομάσθηκε σε Ανωτέρα Σχολή Βιομηχανικών Σπουδών και σκοπός της ορίσθηκε η συστηματική, " +
                "θεωρητική και πρακτική κατάρτιση διοικητικών στελεχών.\r\n\r\n    Το 1949, με το Ν.Δ. 1245/49, ολοκληρώθηκε η οργάνωση της.\r\n\r\n" +
                "    Τo 1958 Η Ανωτέρα Σχολή Βιομηχανικών Σπουδών μετονομάσθηκε σε Ανωτάτη Βιομηχανική Σχολή και ορίσθηκε έδρα της ο Πειραιάς (ΝΔ 3876/58)." +
                " Η φοίτηση είναι τετραετής και τα πτυχία που χορηγούνται είναι ισότιμα των άλλων ΑΕΙ.\r\n\r\n    " +
                "Από το 1966 (ΝΔ 4578/1966) η σχολή λειτούργησε ως ΝΠΔΔ.\r\n\r\n    " +
                "Από το ακαδημαϊκό έτος 1971-1972 οι σπουδές στη Σχολή διαχωρίστηκαν από το δεύτερο έτος σε σπουδές Οικονομικών Επιστημών " +
                "και Οργάνωσης και Διοίκησης Επιχειρήσεων (υπ. απόφ. 146652/71)\r\n\r\n    Από το ακαδημαϊκό έτος 1977-1978 λειτούργησε" +
                " το Στατιστικής και Ασφαλιστικής Επιστήμης.\r\n\r\n    Με το Ν.1268/82 η Σχολή λειτούργησε αρχικά ως μονοτμηματικό ΑΕΙ." +
                " Με το ΠΔ 43/1984 όμως η Σχολή οργανώθηκε έτσι ώστε να περιλαμβάνει τρία τμήματα : Οικονομικών Επιστημών," +
                " Οργάνωσης και Διοίκησης Επιχειρήσεων και Στατιστικής και Ασφαλιστικής Επιστήμης.\r\n\r\n    " +
                "Τον Ιούνιο του 1989, με το ΠΔ 377/89, η Σχολή μετονομάσθηκε σε Πανεπιστήμιο Πειραιώς, στο οποίο προστέθηκαν τρία ακόμα Τμήματα Σπουδών," +
                " δηλαδή:\r\n\r\n          - Χρηματοοικονομικής και Τραπεζικής Διοικητικής.\r\n          - Ναυτιλιακών Σπουδών\r\n          " +
                "- Τεχνολογίας και Συστημάτων Παραγωγής\r\n\r\n    Από το ακαδημαϊκό έτος 1990-1991 στα ήδη λειτουργούντα τρία Τμήματα " +
                "(Οικονομικής Επιστήμης, Οργάνωσης και Διοίκησης Επιχειρήσεων, Στατιστικής και Ασφαλιστικής Επιστήμης), προστέθηκαν σε λειτουργία" +
                " μόνο τα δύο νέα από τα τρία προβλεπόμενα.\r\n\r\n          - Τμήμα Χρηματοοικονομικής και Τραπεζικής Διοικητικής\r\n          " +
                "- Τμήμα Ναυτιλιακών Σπουδών\r\n\r\n    Το Τμήμα Βιομηχανικής Διοίκησης και Τεχνολογίας  άρχισε να λειτουργεί από το ακαδημαϊκό έτος " +
                "1991-1992 ως Τμήμα Τεχνολογίας και Συστημάτων Παραγωγής και μετονομάσθηκε με το Π.Δ. 113/30-4-2002/ ΦΕΚ 95\r\n\r\n    " +
                "Το Τμήμα Πληροφορικής άρχισε να λειτουργεί από το ακαδημαϊκό έτος 1992-1993.\r\n\r\n    " +
                "Το Τμήμα Τεχνολογικής Εκπαίδευσης άρχισε να λειτουργεί από το ακαδημαϊκό έτος 1999-2000, το οποίο σύμφωνα με το άρθρο 3 παρ.2δ.γγ." +
                " του Ν.3027/28-6-2002/ΦΕΚ 152, μετονομάσθηκε σε Τμήμα Διδακτικής της Τεχνολογίας και Ψηφιακών Συστημάτων. " +
                "Κατόπιν, σύμφωνα με το Π.Δ. 151/2009, ΦΕΚ 194/Α'/1-11-2009, το Τμήμα μετονομάστηκε σε Τμήμα Ψηφιακών Συστημάτων.\r\n\r\n    " +
                "Το Τμήμα Διεθνών και Ευρωπαϊκών Σπουδών άρχισε να λειτουργεί από το ακαδημαϊκό έτος 2000-2001.\r\n    " +
                "Το Τμήμα Τουριστικών Σπουδών άρχισε να λειτουργεί από το ακαδημαϊκό έτος 2017-2018.\r\n";*/
        }

        protected override void NavButton3_Click(object sender, EventArgs e)
        {
            //label1.Text = "Εγκαταστάσεις Πανεπιστημίου";
            //pictureBox1.ImageLocation = "..\\..\\Resources\\unipi_main_entr.png";
            //pictureBox2.ImageLocation = "..\\..\\Resources\\unipi_remote1.png";
            /*label2.Text = "\tΚεντρικό Κτίριο οδ. Καραολή & Δημητρίου 80\r\n\n" +
                                "\tΚτίρια οδ. Δεληγιώργη & Tσαμαδού\r\n\n" +
                                "\tΚτίριο οδ. Γρ. Λαμπράκη 21 & Διστόμου\r\n\n" +
                                "\tΚτίριο οδ. Ανδρούτσου 150\r\n\n" +
                                "\tΚτίριο οδ. Γρ. Λαμπράκη 126\r\n\n" +
                                "\tΚτίριο οδ. Ζέας 82\r\n\n" +
                                "\tΚτιριακό Συγκρότημα Νίκαιας ";*/
        }

        protected override void NavButton4_Click(object sender, EventArgs e)
        {
            //label1.Text = "Αποστολή Πανεπιστημίου";

            //pictureBox1.ImageLocation = "..\\..\\Resources\\unipi_library.png";
            //pictureBox2.ImageLocation = "..\\..\\Resources\\unipi_comLab.png";

            /*label2.Text = "H αποστολή του Πανεπιστημίου Πειραιώς, στο πλαίσιο που εξ αρχής του ανέθεσε η Ελληνική Πολιτεία, είναι να εκπαιδεύει," +
                                " να παράγει νέα γνώση, να καλλιεργεί το πνεύμα των νέων, να προάγει τις αξίες της ελευθερίας, της δημοκρατίας " +
                                "και της προσφοράς στις υποθέσεις της Ελλάδας. Ειδικότερα, η αποστολή του Πανεπιστημίου είναι:\r\n1. Nα παράγει " +
                                "και να μεταδίδει τη γνώση με την έρευνα και τη διδασκαλία, να προετοιμάζει τους φοιτητές για την εφαρμογή της σε " +
                                "όλους τους τομείς της οικονομικής και κοινωνικής ζωής.\r\n2. Nα παρέχει υψηλού επιπέδου ανώτατη εκπαίδευση και " +
                                "να συμβάλλει στη διά βίου μάθηση με σύγχρονες μεθόδους διδασκαλίας, περιλαμβανομένης και της διδασκαλίας από " +
                                "απόσταση, με βάση την επιστημονική και τεχνολογική έρευνα στο ανώτερο επίπεδο ποιότητας, σύμφωνα με τα " +
                                "διεθνώς αναγνωρισμένα κριτήρια.\r\n3. Nα προωθεί την αριστεία στην εκπαίδευση και την αξιοποίηση της γνώσης, " +
                                "με στόχο τη διάπλαση επιστημόνων με αξίες.\r\n4. Nα αναπτύσσει και να υποστηρίζει την έρευνα για την αντιμετώπιση " +
                                "των προκλήσεων σε τομείς αιχμής.\r\n5. Nα συμβάλλει στην πρόοδο της επιχειρηματικότητας και στην ανάπτυξη " +
                                "της καινοτομίας.\r\n6. Nα προάγει την εξωστρέφεια και τη συνεργασία με ακαδημαϊκούς, ερευνητικούς," +
                                " κοινωνικούς και άλλους φορείς, για την ανάπτυξη του Ιδρύματος και της κοινωνίας.\r\n7. Nα λειτουργεί" +
                                " ως πόλος αναφοράς, πεδίο γόνιμου διαλόγου και ελεύθερης ανάπτυξης ιδεών για το τοπικό και εθνικό οικονομικό " +
                                "και κοινωνικό οικοσύστημα.\r\nΣτο πλαίσιο της παραπάνω αποστολής του, το Πανεπιστήμιο Πειραιώς παρέχει ποιοτική και" +
                                " ολοκληρωμένη εκπαίδευση, εναρμονιζόμενη με τις σύγχρονες τάσεις της επιστήμης, της τεχνολογίας " +
                                "και της διεθνούς επιστημονικής πρακτικής.";*/
        }

        protected override void NavButton5_Click(object sender, EventArgs e)
        {
            //label1.Text = "Δραστηριότητες Πανεπιστημίου";
            //label2.Text = "";
            //NavigateToForm<ViewEventsForm>();
        }

    }
}
