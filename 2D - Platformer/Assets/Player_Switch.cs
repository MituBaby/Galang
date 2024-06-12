using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Switch : MonoBehaviour
{
    public GameObject kakak;
    public GameObject kakakPick;
    public GameObject adik;
    public GameObject adikPick;
    public GameObject adikprefab;

    private CharacterController2D kakakController;
    private PlayerMovement kakakMovement;
    //private CharacterController2D adikController;
    private PlayerMovement adikMovement;
    private FollowKakak adikFollowing;

    private SpriteRenderer adikrender;

    private bool isKakakActive = true;
    private GameObject instantiatedAdikPrefab;

    void Start()
    {
        // Mendapatkan komponen dari kakak dan adik
        //kakakController = kakak.GetComponent<CharacterController2D>();
        kakakMovement = kakak.GetComponent<PlayerMovement>();
        //adikController = adik.GetComponent<CharacterController2D>();
        adikMovement = adik.GetComponent<PlayerMovement>();
        adikFollowing = adik.GetComponent<FollowKakak>();

        adikrender = adik.GetComponent<SpriteRenderer>();

        // Awalnya, hanya kakak yang aktif
        SetActiveCharacter(true);
    }

    void Update()
    {
        // Ketika tombol F ditekan, ganti karakter
        if (Input.GetKeyDown(KeyCode.F))
        {
            isKakakActive = !isKakakActive;
            SetActiveCharacter(isKakakActive);
        }
    }

    void SetActiveCharacter(bool isKakak)
    {
        if (isKakak)
        {
            // Aktifkan kakak, nonaktifkan adik
            //kakakController.enabled = true;
            kakakMovement.enabled = true;
            kakakPick.SetActive(true);
            //adikController.enabled = false;
            //adikMovement.enabled = false;
            adikFollowing.enabled = true;
            adikPick.SetActive(false);
            adik.SetActive(true);
            adikrender.enabled = true;

            // Hapus objek prefab jika ada
            if (instantiatedAdikPrefab != null)
            {
                Destroy(instantiatedAdikPrefab);
                instantiatedAdikPrefab = null;
            }
        }
        else
        {
            // Aktifkan adik, nonaktifkan kakak
            //kakakController.enabled = false;
            kakakMovement.enabled = false;
            kakakPick.SetActive(false);
            //adikController.enabled = true;
            //adikMovement.enabled = true;
            adikFollowing.enabled = true;
            adikPick.SetActive(true);
            adikrender.enabled = false;

            // Instansiasi objek prefab di posisi adik
            if (instantiatedAdikPrefab == null)
            {
                instantiatedAdikPrefab = Instantiate(adikprefab, adik.transform.position, Quaternion.identity);
            }
        }
    }

    void SetFacingDirection(GameObject activeCharacter, GameObject targetCharacter)
    {
        Vector3 scale = activeCharacter.transform.localScale;
        if (activeCharacter.transform.position.x < targetCharacter.transform.position.x)
        {
            scale.x = Mathf.Abs(scale.x); // Menghadap kanan
        }
        else
        {
            scale.x = -Mathf.Abs(scale.x); // Menghadap kiri
        }
        activeCharacter.transform.localScale = scale;
    }
}
