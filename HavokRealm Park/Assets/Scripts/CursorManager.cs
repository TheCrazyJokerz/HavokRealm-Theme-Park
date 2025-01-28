using UnityEngine;
using UnityEngine.SceneManagement;

public class CursorManager : MonoBehaviour
{
    // List of scene names where the cursor should be hidden
    public string[] scenesToHideCursor;

    void Awake()
    {
        // Prevent this GameObject from being destroyed when switching scenes
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        // Manage the cursor visibility when the game starts
        ManageCursor();

        // Listen for scene changes to reapply cursor settings
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Reapply cursor settings when a new scene is loaded
        ManageCursor();
    }

    private void ManageCursor()
    {
        // Get the name of the currently active scene
        string currentScene = SceneManager.GetActiveScene().name;

        // Check if the current scene is in the list of scenes to hide the cursor
        if (System.Array.Exists(scenesToHideCursor, scene => scene == currentScene))
        {
            Cursor.visible = false; // Hide the cursor
            Cursor.lockState = CursorLockMode.Locked; // Lock the cursor to the center
        }
        else
        {
            Cursor.visible = true; // Show the cursor
            Cursor.lockState = CursorLockMode.None; // Free the cursor
        }
    }

    void OnDestroy()
    {
        // Unsubscribe from the sceneLoaded event when the object is destroyed
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
