using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    [SerializeField] public float damage = 21f;
    [SerializeField] public float fire_rate = 10; //скорость стрельбы
    [SerializeField] public float shot_range = 15f; //зона поражения функций
    [SerializeField] public float force_bullet = 500f;

    [SerializeField] public ParticleSystem shot_effect;
    [SerializeField] public AudioClip shot_sfx; //звук выстрела (файл)
    [SerializeField] public AudioSource shot_sound_source; //воспроизводит запись звука

    [SerializeField] public Transform bullet_spawn_pos;
    [SerializeField] public Camera camera;
    [SerializeField] public GameObject bullet_hole;

    private float next_fire;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > next_fire)
        {
            next_fire = Time.time + 1f / fire_rate;
            Shot();
        }
    }

    void Shot()
    {
        shot_effect.Play();

        //воспроизведение звука выстрела
        shot_sound_source.PlayOneShot(shot_sfx);
        
        RaycastHit hit;
        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, shot_range))
        {
            if (hit.rigidbody != null)
            {
                var tmp_bullet_hole = Instantiate(bullet_hole, hit.point, Quaternion.LookRotation(hit.normal), hit.collider.gameObject.transform); //hit.collider.gameObject.transform привязывает рисунок к тому, куда попаля пуля
                Destroy(tmp_bullet_hole, 2f);

                hit.rigidbody.AddForce(-hit.normal * force_bullet);
            }
        }
        else 
        {

        }


    }
}
