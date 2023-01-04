// Used by InputAxisState to determine current input value versus an off value.
// Typically, this is 1 versus 0 (1 being pressed, 0 being not pressed).
// For controllers with an analog stick, value can be in between if the analog stick is pressed halfway.
public enum Condition
{
    GreaterThan,
    LessThan
}
