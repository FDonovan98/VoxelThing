public class PlaceableBlock : Item
{
    override void AltFire()
    {
        PlaceBlock(/* Raycast from screen. Return hit position */);
    }

    bool isExposed = false;
    public bool isOpaque {get;}

    // Call CheckIfExposed().
    // If true, enable renderer, physics (if applicable), and simulation (if applicable)
    private void OnBecameVisible()
    {
        
    }

    // Disable renderer.
    // After x number of seconds (can use yield statement) check if player is outside of simulationRange.
    // If true, disable physics.
    // If false, check again in x seconds.
    // Stop checks if OnBecomeVisible() is called before physics are disabled.
    private void OnBecameInvisible() 
    {
        
    }

    // If overrideIsExposed != null.
        // Raycast from all 6 faces to find neighboring blocks.
        // If no block is found in a direction, return true.
        // If a block is found but isOpaque is false, return true.
        // Else, return false.
    // Else, set isExposed to overrideIsExposed.
    void CheckIfExposed(bool overrideIsExposed = null)
    {

    }

    // Round spawnLocation so block will spawn aligned with grid system.
    // Call CheckIfExposed();
    void PlaceBlock(Vector3 spawnLocation)
    {
        
    }

    // Round hit.position in plane perpendicular to hit.normal.
        // Cast Vector3 to float[3] to make iterating through a loop easier.
    // Call Placeblock(roundedPosition).
    void PlaceBlock (RaycastHit hit)
    {
        float[] position = (float[])hit.position;
        float[] normal = (float[])hit.normal;

        for (int i = 0; i < position.Length; i++)
        {
            if (normal[i] == 0.0f)
            {
                position[i] = Math.Round(position[i]);
            }
            else
            {
                position[i] += 0.5f * normal[i];
            }
        }

        PlaceBlock(new Vector3(position));
    }

    // Call CheckIfExposed(true) on any surrounding block;
    void RemoveBlock(RemovalType removalType)
    {

    }
}

// Cast to convert Vector3 to float[].
public static explicit operator float[](Vector3 value)
{
    float[] x = new float[3];
    x[0] = value.x;
    x[1] = value.y;
    x[2] = value.z;

    return x;
}