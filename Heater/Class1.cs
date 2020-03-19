namespace Zambion.Test
{
    /* Sets the heater state based on switch state and temperature
     * 
     * Flow:
     *  - if switch is on and temperature greater or equal to 23, return true, else return false
     *  - if switch is off and temperature less than  or equal to 5, return true, else return false
     */
    public class Heater
    {
        public static bool SetState(float temperature, bool heating_switch_state)
        {
            if (heating_switch_state)
            {
                switch (temperature >= 23)
                {
                    case true:
                        return false;
                    default:
                        return true;
                }
            }
            else
            {
                switch (temperature <= 5)
                {
                    case true:
                        return true;
                    default:
                        return false;
                }
            }
        }
    }
}
