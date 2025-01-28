using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Jump();
        }

        /*var verticalInput = Input.GetAxis("Vertical");
        print("Moving: " + verticalInput);
		var horizontalInput = Input.GetAxis("Horizontal");
		print("Horizontal: " + horizontalInput);

		animator.SetFloat("Vertical", verticalInput);
		animator.SetFloat("Horizontal", horizontalInput);*/

	}

    void Jump() 
    {
        animator.SetTrigger("Jump");
    }

}
