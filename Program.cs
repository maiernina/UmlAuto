using UmlAuto;

Auto a1 = new Auto(120, "Opel", "silber");
Auto a2 = new Auto(120, "Opel");

// funktioniert nicht, da kein Konstrukor ohne Parameter vorhanden ist
// Auto a3 = new Aut0();

a1.Fahre();
a2.Fahre();