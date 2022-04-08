using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;
    public Animator animator;
    public float speed = 5f;
    public float vertical = 5f;
    public float horizontal = 5f;

    public Sprite lookDown;
    public Sprite lookUp;
    public Sprite lookLeft;
    public Sprite lookRight;

    public PhotonView photonView;
    public bool is_paused=false;
    public RectTransform panel;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        spriteRenderer = this.GetComponent<SpriteRenderer>();
        animator = this.GetComponent<Animator>();
        photonView = this.GetComponent<PhotonView>();
    }
    void Update()
    {
        is_paused = panel.gameObject.activeSelf;
        if (Input.GetKeyDown(KeyCode.Escape))
            is_paused =!is_paused;
        if (photonView.IsMine&&!is_paused)
        {
            horizontal = Input.GetAxisRaw("Horizontal");
            vertical = Input.GetAxisRaw("Vertical");
            animator.SetInteger("horizontal", (int)horizontal);
            animator.SetInteger("vertical", (int)vertical);
            if (horizontal > 0)
                spriteRenderer.sprite = lookRight;
            else if (horizontal < 0)
                spriteRenderer.sprite = lookLeft;
            if (vertical > 0)
                spriteRenderer.sprite = lookUp;
            else if (vertical < 0)
                spriteRenderer.sprite = lookDown;

            Vector3 vector3 = new Vector3(horizontal * speed, vertical * speed, 0);
            rb.velocity = vector3;
        }
        if (is_paused)
        {
            Time.timeScale = 0;
        }
        else if (!is_paused)
        {
            Time.timeScale = 1;
        }
        panel.gameObject.SetActive(is_paused);
    }
}
