using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CustomerOrderManager : MonoBehaviour
{
    
    public GameObject orderTicketManager;
    public GameObject activeOrder = null;
    public Order order;
    public CustomerOrderGenerator orderGenerator;

    public int orderNumber;

    [Header("CustomerName")]
    public string firstName;
    public string lastName;
    public string plantName;

    [Header("Height")]
    public float heightWanted;
    public float heightAdded;

    public HeightManagerGrabbable heightManager;

    [Header("Eyes")]
    public string eyeColourWanted;
    public string eyeColourAdded;

    public ButtonManager eyeButtonManager;

    [Header("Hair")]
    public string hairColourWanted;
    public string hairColourAdded;

    public HairButtonManager hairButtonManager;

    [Header("Personality One")]
    public string personalityOneWanted;
    public string personalityOneAdded;

    public float personalityOneAmountWanted;
    public float personalityOneAmountAdded;

    [Header("Personality two")]
    public string personalityTwoWanted;
    public string personalityTwoAdded;

    public float personalityTwoAmountWanted;
    public float personalityTwoAmountAdded;



    public PouringMechanic energeticBeakerFull;
    public PouringMechanic openmindednessBeakerFull;
    public PouringMechanic kindessBeakerFull;
    public PouringMechanic extroversionBeakerFull;

    public bool choosingPersonalityOne;
    public bool choosingPersonalityTwo;

    public bool hasBeenReset;

    public bool allIngredientsAdded;

    public bool addedHeight;
    public bool addedEyeColour;

    public bool addedHairColour;
    public bool addedPersonalityOne;
    public bool addedPersonalityTwo;

    public bool qualityCalculated;


    public Button cauldronEmpty;
    public MoneyManager moneyManager;
    public int emptyCauldronAmount;

    public AudioSource buttonClick;

    public TextMeshProUGUI cauldronChecklistText;


    private bool hairChecklist;
    private bool eyeChecklist;
    private bool personalityChecklistOne;
    private bool personalityChecklistTwo;
    private bool heightChecklist;

    //float numberToCalculated;

    // Start is called before the first frame update
    void Start()
    {
        //orderTicketManager = GameObject.Find("OrderTicketManager");
        
        
        
        choosingPersonalityOne = true;

        hasBeenReset = false;

        allIngredientsAdded = false;

        cauldronChecklistText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (addedEyeColour || addedHairColour || addedPersonalityTwo || addedPersonalityOne || addedHeight)
        //&& personalityOneAdded != null && personalityTwoAdded != null && choosingPersonalityOne == false && choosingPersonalityTwo == false)
        {
            cauldronEmpty.interactable = true;



        }
        else
        {
            cauldronEmpty.interactable = false;

        }

        if (heightAdded != 0)
        {
            addedHeight = true;
            //cauldronChecklistText.text = cauldronChecklistText.text + n/ + " Growth Substance";

            if (!heightChecklist)
            {
                cauldronChecklistText.text += "\n - Growth Substance";
                heightChecklist = true;
            }
        }

        if (eyeColourAdded != "")
        {
            addedEyeColour = true;

            

            if (!eyeChecklist)
            {
                cauldronChecklistText.text += "\n - Eyes";
                eyeChecklist = true;
            }
            
        }

        hairColourAdded = hairButtonManager.hairSelection;

        if (hairColourAdded != "")
        {
            addedHairColour = true;

            if (!hairChecklist)
            {
                cauldronChecklistText.text += "\n - Hair";
                hairChecklist = true;
            }

            //cauldronChecklistText.text = cauldronChecklistText.text + "n/ + Hair";
        }

        if (choosingPersonalityOne == false)
        {
            addedPersonalityOne = true;
            //cauldronChecklistText.text = cauldronChecklistText.text + "n/ + Personality Serum";

            if (!personalityChecklistOne)
            {
                cauldronChecklistText.text += "\n - Personality Serum +1";
                personalityChecklistOne = true;
            }
        }
        if (choosingPersonalityOne == false && choosingPersonalityTwo == false)
        {
            addedPersonalityTwo = true;
            //cauldronChecklistText.text = cauldronChecklistText.text + "n/ + Personality Serum";

            if (!personalityChecklistTwo)
            {
                cauldronChecklistText.text += "\n - Personality Serum +1";
                personalityChecklistTwo = true;
            }
        }

        eyeColourAdded = eyeButtonManager.eyeSelection;

        heightAdded = heightManager.heightSelection;

        if (orderTicketManager.GetComponent<OrderTicketManager>().totalOrderTickets > 0) 
        {
            orderTicketManager.GetComponent<OrderTicketManager>().activeOrder = orderTicketManager.GetComponent<OrderTicketManager>().orderTickets[orderTicketManager.GetComponent<OrderTicketManager>().currentOrderTicket];
            activeOrder = orderTicketManager.GetComponent<OrderTicketManager>().activeOrder;
            order = activeOrder.GetComponent<Order>();

            orderTicketManager.GetComponent<OrderTicketManager>().AddOrder();

            if(orderTicketManager.GetComponent<OrderTicketManager>().totalOrderTickets == 1)
            {
                orderTicketManager.GetComponent<OrderTicketManager>().NextOrder();
            }

            //orderTicketManager.GetComponent<OrderTicketManager>().UpdateOrderTicketText();

            //orderTicketManager.GetComponent<OrderTicketManager>().activeOrder = orderTicketManager.GetComponent<OrderTicketManager>().orderTickets[orderTicketManager.GetComponent<OrderTicketManager>().currentOrderTicket - 1];

            orderNumber = order.number;

            firstName = order.orderFirstName;
            lastName = order.orderLastName;
            plantName = order.orderPlantName;

            heightWanted = order.orderHeightNumber;
            eyeColourWanted = order.orderEyeColour;
            hairColourWanted = order.orderHairColour;
            personalityOneWanted = order.orderPersonalityOne;
            personalityTwoWanted = order.orderPersonalityTwo;


            //heightWanted = orderGenerator.heightNumber;

            HeightPercentageWanted(order.orderHeightNumber, orderGenerator.heights.Length);
            PersonalityOnePercentageWanted(order.orderPersonalityOneNumber, orderGenerator.personalityOneArrayLength);
            PersonalityTwoPercentageWanted(order.orderPersonalityOneNumber, orderGenerator.personalityTwoArrayLength);


            






            if (choosingPersonalityOne)
            {
                if (energeticBeakerFull.beakerFull > 0)
                {


                    if (energeticBeakerFull.pouring == false)
                    {
                        personalityOneAdded = "energetic";
                        personalityOneAmountAdded = energeticBeakerFull.beakerFull;


                        choosingPersonalityOne = false;

                        choosingPersonalityTwo = true;


                    }
                    //
                }
                if (openmindednessBeakerFull.beakerFull > 0)
                {

                    if (openmindednessBeakerFull.pouring == false)
                    {
                        personalityOneAdded = "openminded";
                        personalityOneAmountAdded = openmindednessBeakerFull.beakerFull;


                        choosingPersonalityOne = false;

                        choosingPersonalityTwo = true;


                    }
                }
                if (kindessBeakerFull.beakerFull > 0)
                {

                    if (kindessBeakerFull.pouring == false)
                    {
                        personalityOneAdded = "kind";
                        personalityOneAmountAdded = kindessBeakerFull.beakerFull;


                        choosingPersonalityOne = false;

                        choosingPersonalityTwo = true;


                    }
                }
                if (extroversionBeakerFull.beakerFull > 0)
                {

                    if (extroversionBeakerFull.pouring == false)
                    {
                        personalityOneAdded = "extroversion";
                        personalityOneAmountAdded = extroversionBeakerFull.beakerFull;


                        choosingPersonalityOne = false;

                        choosingPersonalityTwo = true;


                    }
                }

            }
            if (choosingPersonalityTwo)
            {
                if (hasBeenReset == false)
                {
                    ResetBeakerFillAmounts();
                }
                else
                {


                    if (energeticBeakerFull.beakerFull > 0)
                    {


                        if (energeticBeakerFull.pouring == false)
                        {
                            personalityTwoAdded = "energetic";
                            personalityTwoAmountAdded = energeticBeakerFull.beakerFull;

                            choosingPersonalityTwo = false;
                        }


                    }
                    if (openmindednessBeakerFull.beakerFull > 0)
                    {

                        if (openmindednessBeakerFull.pouring == false)
                        {
                            personalityTwoAdded = "openminded";
                            personalityTwoAmountAdded = openmindednessBeakerFull.beakerFull;

                            choosingPersonalityTwo = false;
                        }

                    }
                    if (kindessBeakerFull.beakerFull > 0)
                    {


                        if (kindessBeakerFull.pouring == false)
                        {
                            personalityTwoAdded = "kind";
                            personalityTwoAmountAdded = kindessBeakerFull.beakerFull;

                            choosingPersonalityTwo = false;
                        }

                    }
                    if (extroversionBeakerFull.beakerFull > 0)
                    {

                        if (extroversionBeakerFull.pouring == false)
                        {
                            personalityTwoAdded = "extroversion";

                            personalityTwoAmountAdded = extroversionBeakerFull.beakerFull;
                            choosingPersonalityTwo = false;
                        }


                    }
                }
            }

            //heightAdded > 0 &&

            //else
            //{
            // CompareWantedAdded();
            // }
            //personalityOneAdded = 
        }
        
        
    }

    public void HeightPercentageWanted(int numberToCalculate, int arrayLength)
    {
        if(arrayLength == 5)
        {
            if (numberToCalculate == 0)
            {
                heightWanted = 90f;
            }
            if (numberToCalculate == 1)
            {
                heightWanted = 70f;
            }
            if (numberToCalculate == 2)
            {
                heightWanted = 50f;
            }
            if (numberToCalculate == 3)
            {
                heightWanted = 30f;
            }
            if (numberToCalculate == 4)
            {
                heightWanted = 10f;
            }
        }



    }

    public void PersonalityOnePercentageWanted(int numberToCalculate, int arrayLength)
    {

        if (arrayLength == 5)
        {
            if (numberToCalculate == 0)
            {
                personalityOneAmountWanted = 90f;
            }
            if (numberToCalculate == 1)
            {
                personalityOneAmountWanted = 70f;
            }
            if (numberToCalculate == 2)
            {
                personalityOneAmountWanted = 50f;
            }
            if (numberToCalculate == 3)
            {
                personalityOneAmountWanted = 30f;
            }
            if (numberToCalculate == 4)
            {
                personalityOneAmountWanted = 10f;
            }
        }
 

        if (arrayLength == 4)
        {
            if (numberToCalculate == 0)
            {
                personalityOneAmountWanted = 87.5f;
            }
            if (numberToCalculate == 1)
            {
                personalityOneAmountWanted = 62.5f;
            }
            if (numberToCalculate == 2)
            {
                personalityOneAmountWanted = 37.5f;
            }
            if (numberToCalculate == 3)
            {
                personalityOneAmountWanted = 12.5f;
            }
        }
    }

    public void PersonalityTwoPercentageWanted(int numberToCalculate, int arrayLength)
    {

        if(arrayLength == 5)
        {
            if (numberToCalculate == 0)
            {
                personalityTwoAmountWanted = 90f;
            }
            if (numberToCalculate == 1)
            {
                personalityTwoAmountWanted = 70f;
            }
            if (numberToCalculate == 2)
            {
                personalityTwoAmountWanted = 50f;
            }
            if (numberToCalculate == 3)
            {
                personalityTwoAmountWanted = 30f;
            }
            if (numberToCalculate == 4)
            {
                personalityTwoAmountWanted = 10f;
            }
        }

        if (arrayLength == 4)
        {
            if (numberToCalculate == 0)
            {
                personalityTwoAmountWanted = 87.5f;
            }
            if (numberToCalculate == 1)
            {
                personalityTwoAmountWanted = 62.5f;
            }
            if (numberToCalculate == 2)
            {
                personalityTwoAmountWanted = 37.5f;
            }
            if (numberToCalculate == 3)
            {
                personalityTwoAmountWanted = 12.5f;
            }
        }

    }



    public void ResetBeakerFillAmounts()
    {
        energeticBeakerFull.beakerFull = 0;
        openmindednessBeakerFull.beakerFull = 0;
        kindessBeakerFull.beakerFull = 0;
        extroversionBeakerFull.beakerFull = 0;

        //new line added. Turns the actual value of the slider back to 0. ALFONSO LINE
        energeticBeakerFull.beaker.value = 0;
        openmindednessBeakerFull.beaker.value = 0;
        kindessBeakerFull.beaker.value = 0;
        extroversionBeakerFull.beaker.value = 0;

        hasBeenReset = true;
    }

    public void ResetOrderManager()
    {
        hairButtonManager.ResetHairButtonManager();
        eyeButtonManager.ResetEyeButtonManager();
        ResetBeakerFillAmounts();
        heightManager.ResetHeightManager();

        choosingPersonalityOne = true;
        choosingPersonalityTwo = false;

        addedHeight = false;
        addedEyeColour = false;
        addedHairColour = false;
        addedPersonalityOne = false;
        addedPersonalityTwo = false;
        qualityCalculated = false;

        hasBeenReset = false;

        allIngredientsAdded = false;

        //heightWanted = 0;
        heightAdded = 0;

        //eyeColourWanted = "";
        eyeColourAdded = "";

        //hairColourWanted = "";
        hairColourAdded = "";

        //personalityOneWanted = "";
        personalityOneAdded = "";
        //personalityOneAmountWanted = 0;
        personalityOneAmountAdded = 0;

        //personalityTwoWanted = "";
        personalityTwoAdded = "";
        //personalityTwoAmountWanted = 0;
        personalityTwoAmountAdded = 0;

        //dateQuality = 0;
        //customerFinalPayment = 0;
        //
        cauldronChecklistText.text = " ";

        hairChecklist = false;
eyeChecklist =false; 
 personalityChecklistOne = false;
 personalityChecklistTwo =false;
  heightChecklist = false;
}

    public void EmptyCauldron()
    {
        ResetOrderManager();
        moneyManager.DecreaseMoney(emptyCauldronAmount);
    }
    
}
