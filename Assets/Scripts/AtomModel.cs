using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtomModel : MonoBehaviour
{
    public Sprite solidSprite, liquidSprite, gasSprite;
    public SpriteRenderer monitorSprite;

	void Start()
    {
        //startPosition = transform.position;

        monitorSprite = gameObject.GetComponent<SpriteRenderer>();
        solidSprite = gameObject.GetComponent<Sprite>();
        liquidSprite = gameObject.GetComponent<Sprite>();
        gasSprite = gameObject.GetComponent<Sprite>();

		//Sprite sp = Resources.Load<Sprite>("Sprites/my_sprite");
		/*solidSprite = Resources.Load<Sprite>("Exercise2D/solidSprite");
		liquidSprite = Resources.Load<Sprite>("Exercise2D/liquidSprite");
		gasSprite = Resources.Load<Sprite>("Exercise2D/gasSprite");
		monitorSprite = Resources.Load<SpriteRenderer>("MonitorSprite");*/

		//monitorSprite.sprite = solidSprite;
        /*solidSprite = Resources.Load<Sprite>("Solid");
		liquidSprite = Resources.Load<Sprite>("Liquid");
		gasSprite = Resources.Load<Sprite>("Gas");*/

    }

	public void OnTriggerStay(Collider other)
    {
		//Debug.Log("OnTriggerStay");

		if (other.CompareTag("AtomMachine") && this.CompareTag("Solid"))
        {
            monitorSprite.sprite = solidSprite;
            monitorSprite.enabled = true;
			Debug.Log("Katı");
        }
        else if (other.CompareTag("AtomMachine") && this.CompareTag("Liquid"))
        {
            monitorSprite.sprite = liquidSprite;
            monitorSprite.enabled = true;
			Debug.Log("Sıvı");

		}
		else if (other.CompareTag("AtomMachine") && this.CompareTag("Gas"))
        {
            monitorSprite.sprite = gasSprite;
            monitorSprite.enabled = true;
			Debug.Log("Gaz");

		}
	}


	public void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("AtomMachine") && this.CompareTag("Solid"))
		{
			//monitorSprite.sprite = solidSprite;
			monitorSprite.enabled = false;
		}
		else if (other.CompareTag("AtomMachine") && this.CompareTag("Liquid"))
		{
			//monitorSprite.sprite = liquidSprite;
			monitorSprite.enabled = false;
		}
		else if (other.CompareTag("AtomMachine") && this.CompareTag("Gas"))
		{
			//monitorSprite.sprite = gasSprite;
			monitorSprite.enabled = false;
		}
	}

















	/*///public Transform dropArea;
	private float mouseZCoord;

	private bool isTouch;
	private bool isContacting;
	private Vector3 startPosition;

	public Sprite solidSprite, liquidSprite, gasSprite;

	//public List<Sprite> spriteLists = new List<Sprite>();
	public SpriteRenderer monitorSprite;
		//, solidRend, liquidRend, gasRend;
	//public Sprite[] spriteArray;

	public bool isSolid, isLiquid, isGas;

	public Transform dropArea;

	//private Vector3 startPosition;

	void Start()
	{
		//startPosition = transform.position;

		monitorSprite = gameObject.GetComponent<SpriteRenderer>();
		solidSprite = gameObject.GetComponent<Sprite>();
		liquidSprite = gameObject.GetComponent<Sprite>();
		gasSprite = gameObject.GetComponent<Sprite>();

		/*solidSprite = Resources.Load<Sprite>("solidSprite");
		liquidSprite = Resources.Load<Sprite>("liquidSprite");
		gasSprite = Resources.Load<Sprite>("gasSprite");*/
	//monitorSprite.sprite = 

	/*solidSprite = Resources.Load<Sprite>("Solid");
	liquidSprite = Resources.Load<Sprite>("Liquid");
	gasSprite = Resources.Load<Sprite>("Gas");*/

	//spriteArray = Resources.LoadAll<Sprite>();

	/*solidRend.sprite = solidSprite;
	liquidRend.sprite = liquidSprite;
	gasRend.sprite = gasSprite;*/
	//}

	/*public List<Sprite> spriteLists = new List<Sprite>();
	public SpriteRenderer monitorSprite;*/

	/*private void Start()
	{
		startPosition = transform.position;
	}*/
	/*private void OnMouseUp()
	{
		Debug.Log("omu");

		isTouch = false;
		if (isContacting)
		{
			if (isSolid)
			{
				monitorSprite.sprite = solidSprite;
			}
			else if (isLiquid)
			{
				monitorSprite.sprite = liquidSprite;
			}
			else if (isGas)
			{
				monitorSprite.sprite = gasSprite;
			}
			//monitorSprite.sprite = spriteLists[0];
		}
		//else transform.position = startPosition;
	}

	/*private void OnMouseDown()
	{
		Debug.Log("omd");

		isTouch = true;

	}
	*/
	/*private void OnTriggerStay(Collider other)
	{
		Debug.Log("otstay");

		if (other.name == "MonitorSprite")
		{
			isContacting = true;
		}
	}*/
	/*private void OnTriggerExit(Collider other)
	{
		Debug.Log("otexit");
		if (other.name == "MonitorSprite")
		{
			isContacting = false;
		}
	}*/

	/*private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("solidSprite")){
			monitorSprite.sprite = solidSprite;
			monitorSprite.enabled = true;
		}
	}*/


	/*private void OnTriggerStay(Collider other)
	{
		isTouch = false;
		if (isContacting)
		{
			if (other.name == "solidSprite" && isSolid == true)
			{
				//other.gameObject.GetComponent<SpriteRenderer>().sprite = solidSprite;
				other.gameObject.GetComponent<SpriteRenderer>().enabled = true;
			}
			else if (other.name == "liquidSprite" && isLiquid == true)
			{
				//other.gameObject.GetComponent<SpriteRenderer>().sprite = liquidSprite;
				other.gameObject.GetComponent<SpriteRenderer>().enabled = true;

				//monitorSprite.sprite = liquidSprite;
			}
			else if (other.name == "gasSprite" && isGas == true)
			{
				//other.gameObject.GetComponent<SpriteRenderer>().sprite = gasSprite;
				other.gameObject.GetComponent<SpriteRenderer>().enabled = true;

				//monitorSprite.sprite = gasSprite;
			}
			//transform.position = dropArea.position;
			//monitorSprite.sprite = spriteArray[0];

		}
		//else transform.position = startPosition;
	}

	private void OnTriggerExit(Collider other)
	{
		if (isContacting == false)
		{
			if (other.name == "solidSprite" && isSolid == true)
			{
				//other.gameObject.GetComponent<SpriteRenderer>().sprite = solidSprite;
				other.gameObject.GetComponent<SpriteRenderer>().enabled = false;
			}
			else if (other.name == "liquidSprite" && isLiquid == true)
			{
				//other.gameObject.GetComponent<SpriteRenderer>().sprite = liquidSprite;
				other.gameObject.GetComponent<SpriteRenderer>().enabled = false;

				//monitorSprite.sprite = liquidSprite;
			}
			else if (other.name == "gasSprite" && isGas == true)
			{
				//other.gameObject.GetComponent<SpriteRenderer>().sprite = gasSprite;
				other.gameObject.GetComponent<SpriteRenderer>().enabled = false;

				//monitorSprite.sprite = gasSprite;
			}
			//transform.position = dropArea.position;
			//monitorSprite.sprite = spriteArray[0];

		}
	}

	void Update()
	{
		/*if (isContacting)
		{
			if (isSolid)
			{
				monitorSprite.sprite = solidSprite;
			}
			else if (isLiquid)
			{
				monitorSprite.sprite = liquidSprite;
			}
			else if (isGas)
			{
				monitorSprite.sprite = gasSprite;
			}
			//transform.position = dropArea.position;
			//monitorSprite.sprite = spriteArray[0];

		}*/

	/*if (isSolid)
	{
		monitorSprite.sprite = solidSprite;
	}
	else if (isLiquid)
	{
		monitorSprite.sprite = liquidSprite;
	}
	else if (isGas)
	{
		monitorSprite.sprite = gasSprite;
	}*/
	//}

	/*private void OnMouseDown()
{
	isTouch = true;

}

private void OnTriggerStay(Collider other)
{
	if (other.name == "DropArea")
	{
		isContacting = true;
	}
}
private void OnTriggerExit(Collider other)
{
	if (other.name == "DropArea")
	{
		isContacting = false;
	}
}

private void OnMouseUp(Collider other)
{
	isTouch = false;
	if (isContacting)
	{
		transform.position = dropArea.position;
		if (other.CompareTag("Solid"))
		{
			monitorSprite.sprite = solidSprite;
			monitorSprite.enabled = true;
		}
		else if (other.CompareTag("Liquid"))
		{
			monitorSprite.sprite = liquidSprite;
			monitorSprite.enabled = true;
		}
		else if (other.CompareTag("Gas"))
		{
			monitorSprite.sprite = gasSprite;
			monitorSprite.enabled = true;
		}
	}
	//else transform.position = startPosition;
}*/
}
