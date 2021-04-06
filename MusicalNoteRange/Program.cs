using System;

namespace MusicalNoteRange
{
    class Program
    {
        // https://edabit.com/challenge/Z7bgqN8vK5gqrQpqL
        // SOLVED

        // Example: Instrument with range of D4-C7 ->
        // At the lowest octave, A4, B4, C4 are impossible.
        // Can play any other note within the 4th octave (D4,E4,F4,G4).
        // A4, B4 and C4 are all greater values than D4, thus:
        // if(Octave == Instrument.LowestOctave && Note > Instrument.LowestNote) IsValid = false;
        // Vice versa for notes on the highest possible octaves. 

        static void Main(string[] args)
        {
            Instrument piccolo = new("Piccolo", new int[] { 4, 7 }, new char[] { 'D', 'C' });
            Instrument tuba = new("Tuba", new int[] { 1, 4 }, new char[] { 'D', 'F' });
            Instrument guitar = new("Guitar", new int[] { 3, 6 }, new char[] { 'E', 'E' });
            Instrument piano = new("Piano", new int[] { 0, 8 }, new char[] { 'A', 'C' });
            Instrument violin = new("Violin", new int[] { 3, 7 }, new char[] { 'G', 'A' });
            NoteValidation noteValidation = new("Piccolo", "D4", piccolo, tuba, guitar, piano, violin);
            noteValidation.LookUpInstrument();
            noteValidation.SetOctaveToInt();
            noteValidation.IsValidOctalRange();
            noteValidation.IsValidLowerNote();
            noteValidation.IsValidHigherNote();
            Console.Write(noteValidation.IsValidNoteAndOctave());
        }
    }
}
