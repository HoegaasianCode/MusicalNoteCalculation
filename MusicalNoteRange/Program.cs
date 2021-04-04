using System;

namespace MusicalNoteRange
{
    class Program
    {
        // https://edabit.com/challenge/Z7bgqN8vK5gqrQpqL
        // SOLVED

        static void Main(string[] args)
        {
            Instrument piccolo = new("Piccolo", new short[] { 4, 7 }, new char[] { 'D', 'C' });
            Instrument tuba = new("Tuba", new short[] { 1, 4 }, new char[] { 'D', 'F' });
            Instrument guitar = new("Guitar", new short[] { 3, 6 }, new char[] { 'E', 'E' });
            Instrument piano = new("Piano", new short[] { 0, 8 }, new char[] { 'A', 'C' });
            Instrument violin = new("Violin", new short[] { 3, 7}, new char[] { 'G', 'A' });
            NoteValidation noteValidation = new("Piccolo", "A3", piccolo, tuba, guitar, piano, violin);
            noteValidation.LookUpInstrument();
            noteValidation.IsValidOctave();
            noteValidation.IsValidNote();
            bool isValid = noteValidation.IsValidNoteAndOctave();
            Console.Write(isValid);
        }
    }
}
