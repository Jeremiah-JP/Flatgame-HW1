using UnityEngine;

public class Sounds : MonoBehaviour
{

    AudioSource myRatPlayer;
    AudioSource myTrashSource;
    AudioSource myLightSource;
    AudioSource myPigeonSource;
    AudioSource myHelpSource;
    AudioSource myChompSource;
    AudioSource myAngrySource;
    AudioSource mySadSource;
    //AudioSource mySource;

    private bool ratPlayed = false;
    private bool trashPlayed = false;
    private bool PigeonPlayed = false;
    private bool ItemPlayed = false;
    private bool HelpPlayed = false;


    public AudioClip RatCD;
    public AudioClip TrashSource;
    public AudioClip LightSource;
    public AudioClip PigeonSource;
    public AudioClip ItemSource;
    public AudioClip HelpSource;
    public AudioClip ChompSource;
    public AudioClip AngrySource;
    public AudioClip SadSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRatPlayer = GetComponent<AudioSource>();
        myTrashSource = GetComponent<AudioSource>();
        myLightSource = GetComponent<AudioSource>();
        myPigeonSource = GetComponent<AudioSource>();
        myHelpSource = GetComponent<AudioSource>();
        myChompSource = GetComponent<AudioSource>();
        myAngrySource = GetComponent<AudioSource>();
        mySadSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("RAT") && !ratPlayed)
        {
            myRatPlayer.PlayOneShot(RatCD);
            ratPlayed = true;
        }
        if (collision.CompareTag("Trash") && !trashPlayed)
        {
            myTrashSource.PlayOneShot(TrashSource);
            trashPlayed = true;
        }
        if (collision.CompareTag("Trash") && !ItemPlayed)
        {
            myTrashSource.PlayOneShot(ItemSource);
            ItemPlayed = true;
        }
        if (collision.CompareTag("Lights"))
        {
            myLightSource.PlayOneShot(LightSource);
        }
        if (collision.CompareTag("Pigeon") && !PigeonPlayed)
        {
            myPigeonSource.PlayOneShot(PigeonSource);
            PigeonPlayed = true;
        }
        if (collision.CompareTag("Help") && !HelpPlayed)
        {
            myHelpSource.PlayOneShot(HelpSource);
            HelpPlayed = true;
        }
        if (collision.CompareTag("Pizza") )
        {
            myChompSource.PlayOneShot(ChompSource);
           
        }
        if (collision.CompareTag("Angry"))
        {
            myAngrySource.PlayOneShot(AngrySource);

        }
        if (collision.CompareTag("Smile"))
        {
            mySadSource.PlayOneShot(SadSource);

        }
    }
}
