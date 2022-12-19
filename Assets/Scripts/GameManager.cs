using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Collections.Generic;
using PlayFab;
using PlayFab.ServerModels;
using TMPro;
using System.Text;
using PlayFab.ClientModels;
using ItemInstance = PlayFab.ServerModels.ItemInstance;
using GetUserInventoryRequest = PlayFab.ServerModels.GetUserInventoryRequest;
using GetUserInventoryResult = PlayFab.ServerModels.GetUserInventoryResult;
using DG.Tweening;
using System.Linq;

//PARA PRUEBAS
using UnityEngine.Networking;
using Newtonsoft.Json;

public class GameManager : MonoBehaviour
{

    public event Action OnLoading;

    public event Action OnLogin;
    public event Action OnRegister;
    public event Action onOptions;
    public event Action onDescActivity;
    public event Action onAsistenteInfo;
    public event Action onAsistenteStartPaso;
    public event Action onRegisterSpace;
    public event Action onBoxObjetosOpen;
    public event Action onARPositionObject;
    public event Action onAsistenteInfoSave;
    public event Action onNextPaso;
    public event Action onEndActivity;

    public event Action OnItemsMenu;
    public event Action OnARPosition;


    [Header("Practitioner")]
    [SerializeField] private GameObject loginCanvas;
    [SerializeField] private GameObject optionsCanvas;
    [SerializeField] private GameObject descActivityCanvas;
    [SerializeField] private GameObject endActivityCanvas;

    [Header("Practitioner Login")]
    public Text messageText;
    public InputField emailInput;
    public InputField passwordInput;

    [Header("Practitioner Register")]
    public Text messageInfo;
    public InputField emailInputRegister;
    public InputField password1InputRegister;
    public InputField password2InputRegister;


    [Header("Descripcion Actividad")]
    public Text nameAct;
    public Text pacienteAct;
    public Text descAct;
    public Text pasosAct;

    [Header("Asistente Info ")]
    public Text nameActInfo;

    [Header("StartPaso")]
    public Text namePaso1;
    public Text bocadilloNombreAct;
    public Text bocadilloPrimerPaso;
    public Text bocadilloNombreUbicacion;
    public Text bocadilloObjetosPaso1;

    [Header("Objeto a colocar")]
    public Text objetoAColocar;

    [Header("InfoSave")]
    public Text bocadilloSavePaso;
    public Text actividadName;

    [Header("Next Paso")]
    public Text actNamee;
    
    [Header("End Activity")]
    public Text bocadilloNombreActFin;
    public Text actFinName;

    [Header("Datos de la actividad para mostrar en PRACTITIONER")]
    [SerializeField] private Text _tittle0;
    [SerializeField] private Text _tittle1;
    [SerializeField] private Text _tittle2;
    [SerializeField] private Text _tittle3;
    [SerializeField] private Text _tittle4;
    [SerializeField] private Text _tittle5;
    [SerializeField] private Text _tittle6;
    [SerializeField] private Text _tittle7;
    [SerializeField] private Text _tittle8;
    [SerializeField] private Text _tittle9;
    [SerializeField] private Text _tittle10;
    [SerializeField] private Text _tittle11;
    [SerializeField] private Text _tittle12;
    [SerializeField] private Text _tittle13;
    [SerializeField] private Text _tittle14;
    [SerializeField] private Text _tittle15;
    [SerializeField] private Text _tittle16;
    [SerializeField] private Text _tittle17;
    [SerializeField] private Text _tittle18;
    [SerializeField] private Text _tittle19;
    [SerializeField] private Text _tittle20;
    [SerializeField] private Text _tittle21;
    [SerializeField] private Text _tittle22;
    [SerializeField] private Text _tittle23;
    [SerializeField] private Text _tittle24;
    [SerializeField] private Text _tittle25;
    [SerializeField] private Text _tittle26;
    [SerializeField] private Text _tittle27;
    [SerializeField] private Text _tittle28;
    [SerializeField] private Text _tittle29;
    [SerializeField] private Text _tittle30;
    [SerializeField] private Text _tittle31;
    [SerializeField] private Text _tittle32;
    [SerializeField] private Text _tittle33;
    [SerializeField] private Text _tittle34;
    [SerializeField] private Text _tittle35;
    [SerializeField] private Text _tittle36;
    [SerializeField] private Text _tittle37;
    [SerializeField] private Text _tittle38;
    [SerializeField] private Text _tittle39;
    [SerializeField] private Text _tittle40;
    [SerializeField] private Text _tittle41;
    [SerializeField] private Text _tittle42;
    [SerializeField] private Text _tittle43;
    [SerializeField] private Text _tittle44;
    [SerializeField] private Text _tittle45;
    [SerializeField] private Text _tittle46;
    [SerializeField] private Text _tittle47;
    [SerializeField] private Text _tittle48;
    [SerializeField] private Text _tittle49;

    [SerializeField] private Text _description0;
    [SerializeField] private Text _description1;
    [SerializeField] private Text _description2;
    [SerializeField] private Text _description3;
    [SerializeField] private Text _description4;
    [SerializeField] private Text _description5;
    [SerializeField] private Text _description6;
    [SerializeField] private Text _description7;
    [SerializeField] private Text _description8;
    [SerializeField] private Text _description9;
    [SerializeField] private Text _description10;
    [SerializeField] private Text _description11;
    [SerializeField] private Text _description12;
    [SerializeField] private Text _description13;
    [SerializeField] private Text _description14;
    [SerializeField] private Text _description15;
    [SerializeField] private Text _description16;
    [SerializeField] private Text _description17;
    [SerializeField] private Text _description18;
    [SerializeField] private Text _description19;
    [SerializeField] private Text _description20;
    [SerializeField] private Text _description21;
    [SerializeField] private Text _description22;
    [SerializeField] private Text _description23;
    [SerializeField] private Text _description24;
    [SerializeField] private Text _description25;
    [SerializeField] private Text _description26;
    [SerializeField] private Text _description27;
    [SerializeField] private Text _description28;
    [SerializeField] private Text _description29;
    [SerializeField] private Text _description30;
    [SerializeField] private Text _description31;
    [SerializeField] private Text _description32;
    [SerializeField] private Text _description33;
    [SerializeField] private Text _description34;
    [SerializeField] private Text _description35;
    [SerializeField] private Text _description36;
    [SerializeField] private Text _description37;
    [SerializeField] private Text _description38;
    [SerializeField] private Text _description39;
    [SerializeField] private Text _description40;
    [SerializeField] private Text _description41;
    [SerializeField] private Text _description42;
    [SerializeField] private Text _description43;
    [SerializeField] private Text _description44;
    [SerializeField] private Text _description45;
    [SerializeField] private Text _description46;
    [SerializeField] private Text _description47;
    [SerializeField] private Text _description48;
    [SerializeField] private Text _description49;

    //VARIABLE PARA GUARDAR LAS ACTIVIDADES
    List<Activities> actividades = new List<Activities>();
    List<Activity2User> activity2User = new List<Activity2User>();
    List<Entity3D> entity3D = new List<Entity3D>();
    List<InteractiveSpaces> interactiveSpaces = new List<InteractiveSpaces>();
    List<ActivitiesById> activitiesById = new List<ActivitiesById>();
    List<ActivitiesByOwner> activitiesByOwner = new List<ActivitiesByOwner>();

    //Listas de informacion de los pasos
    List<Step> step = new List<Step>();
    Step stepInformation = new Step();
    List<int> stepsIds = new List<int>();
    int stepAux = 0;

    //Variables para saber la cantidad de actividades que hay
    int numActividades = 0;
    int numUsers = 0;
    int numEntity3D = 0;
    int numActivitiesById = 0;
    int numInteractiveSpaces = 0;
    int numActivitiesByOwner = 0;
    int numStep = 0;


    string regUbicacionAntigua = null;

    //Lista de ids de actividades
    List<int> activitiesIds = new List<int>();

    //Lista de llamadas a Botones de actividades
    List<string> usuarios = new List<string>();

    //Patron Singleton
    public static GameManager instance;
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    //START DE LA APLICACIÓN
    void Start()
    {
        //Llamo a la pantalla de loading
        LoadingMenu();
        //Llamo a collect Actividades
    }   

    //MUESTRO PANTALLA DE LOADING
    public void LoadingMenu()
    {
        OnLoading?.Invoke();
        Debug.Log("Loading 0 menu ACTIVATED");
        StartCoroutine(Loadingg());
    }

    IEnumerator Loadingg()
    {
        yield return new WaitForSecondsRealtime(2);
        LoginMenu();
    }

    public void LoginMenu()
    {
        OnLogin?.Invoke();
        Debug.Log("Login menu ACTIVATED");
    }

    public void RegisterMenu()
    {
        Debug.Log("Register menu ACTIVATED");
        OnRegister?.Invoke();
    }

    public void AAAPruebas()
    {
        //StartCoroutine(CollectActivities());
        //StartCoroutine(CollectActivity2User());
        //StartCoroutine(CollectEntity3D());
        //StartCoroutine(CollectInteractiveSpaces());
        //StartCoroutine(CollectActivitiesById());
        //string owner = "Terapeuta2@uclm.es";
        //StartCoroutine(CollectActivitiesByOwner());
        StartCoroutine(CollectStepByActivtyId());
        //StartCoroutine(CollectActivity2UserByActivityId());
        Debug.Log("FUNCION APAGADA");
    }

    IEnumerator CollectActivity2UserByActivityId()
    {
        int idActividad = idActividadSeleccionada;
        //int idActividad = 2;

        UnityWebRequest www = UnityWebRequest.Get("localhost:3001/api/Activity2User/GetUsersAssigned2Activity?id="+idActividad);
        yield return www.Send();

        if (www.isError)
        {
            Debug.Log(www.error);
        }
        var activity2user = JsonConvert.DeserializeObject < List < string >>(www.downloadHandler.text.ToString());
        usuarios = activity2user;
    }
    IEnumerator CollectStepByActivtyId()
    {
        int idActividad = idActividadSeleccionada;
        //int idActividad = 6;

        UnityWebRequest www = UnityWebRequest.Get("http://localhost:3001/api/Steps/GetSteps?idActivity=" + idActividad);
        yield return www.Send();

        if (www.isError)
        {
            Debug.Log(www.error);
        }
        var stepByActivitId = JsonConvert.DeserializeObject<List<Step>>(www.downloadHandler.text);
        step = stepByActivitId;

        foreach(var s in step)
        {
            stepsIds.Add(s.id);
        }

        InfoActivityComplete();
    }
    IEnumerator CollectActivitiesByOwner()
    {
        string owner = emailInput.text;
        List<int> ids = new List<int>();

        //string owner = "Terapeuta1@uclm.es";

        UnityWebRequest www = UnityWebRequest.Get("localhost:3001/api/Activities/GetActivities?owner="+owner);
        yield return www.Send();

        if (www.isError)
        {
            Debug.Log(www.error);
        }
        var actByOwner = JsonConvert.DeserializeObject<List<ActivitiesByOwner>>(www.downloadHandler.text);
        activitiesByOwner = actByOwner;

        foreach (var a in activitiesByOwner)
        {
            /*
            Debug.Log("id -->" + a.Id);
            Debug.Log("Name -->" + a.Name);
            Debug.Log("Description -->" + a.Description);
            Debug.Log("FinalMessageOK -->" + a.FinalMessageOK);
            Debug.Log("FinalMessageError -->" + a.FinalMessageError);
            Debug.Log("MaxTime -->" + a.MaxTime);
            Debug.Log("Owner -->" + a.Owner);
            */
            activitiesIds.Add(a.Id);
            numActivitiesByOwner++;
        }

        

        ActivateOptionsMenu();
    }
    IEnumerator GetStepsById()
    {
        int stepId = stepsIds[stepAux];

        //string owner = "Terapeuta1@uclm.es";

        UnityWebRequest www = UnityWebRequest.Get("http://localhost:3001/api/Steps/GetStep?id=" + stepId);
        yield return www.Send();

        if (www.isError)
        {
            Debug.Log(www.error);
        }

        var stepInfo = JsonConvert.DeserializeObject<Step>(www.downloadHandler.text);
        stepInformation = stepInfo;

        AsistenteStartPasoMenu();
       
        
    }


    public void RegisterButton()
    {
        if (password1InputRegister.text == password2InputRegister.text)
        {
            var request = new RegisterPlayFabUserRequest
            {
                Email = emailInputRegister.text,
                Password = password1InputRegister.text,
                RequireBothUsernameAndEmail = false,
            };
            PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSuccess, OnError);
        }
        else
        {
            messageInfo.text = "LAS CONTRASEÑS NO COINCIDEN";
        }
    }

    void OnRegisterSuccess(RegisterPlayFabUserResult result)
    {
        messageInfo.text = "REGISTRADO CORRECTAMENTE";
    }


    public void PressLoginButton()
    {
        DoLogin(emailInput.text, passwordInput.text);
    }

    public void DoLogin(string email, string pass)
    {
        var request = new LoginWithEmailAddressRequest
        {
            Email = email,
            Password = pass
        };
        PlayFabClientAPI.LoginWithEmailAddress(request, OnLoginSuccess, OnError);
    }

    private void OnLoginSuccess(LoginResult result)
    {
        Debug.Log("Succesful login/account create!!");

        foreach (var acti in actividades.ToList())
        {
            if (acti.Owner != emailInput.text)
            {
                actividades.Remove(acti);
            }
        }

        StartCoroutine("CollectActivitiesByOwner");

    }

    private void OnError(PlayFabError error)
    {
        Debug.Log("Error while logging in/creating account");
        Debug.Log(error.GenerateErrorReport());
    }


    public void ActivateOptionsMenu()
    {
        Debug.Log("Options menu ACTIVATED");
        StopCoroutine("CollectActivitiesByOwner");

        endActivityCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        loginCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        optionsCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        optionsCanvas.transform.GetChild(0).GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        optionsCanvas.transform.GetChild(0).GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        optionsCanvas.transform.GetChild(0).GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        optionsCanvas.transform.GetChild(0).GetChild(2).GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        optionsCanvas.transform.GetChild(0).GetChild(2).GetChild(0).GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        int i = 0;
        int numActividad = 0;

        foreach (var actividad in activitiesByOwner)
        {
            if (numActividad == 0)
            {
                optionsCanvas.transform.GetChild(0).GetChild(2).GetChild(0).GetChild(0).GetChild(i).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
                _tittle0.text = actividad.Name;
                _description0.text = actividad.Description;
                i++;  
            }
            if (numActividad == 1)
            {
                optionsCanvas.transform.GetChild(0).GetChild(2).GetChild(0).GetChild(0).GetChild(i).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
                _tittle1.text = actividad.Name;
                _description1.text = actividad.Description;
                i++;               
            }
            if (numActividad == 2)
            {
                optionsCanvas.transform.GetChild(0).GetChild(2).GetChild(0).GetChild(0).GetChild(i).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
                _tittle2.text = actividad.Name;
                _description2.text = actividad.Description;
                i++;
            }
            if (numActividad == 3)
            {
                optionsCanvas.transform.GetChild(0).GetChild(2).GetChild(0).GetChild(0).GetChild(i).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
                _tittle3.text = actividad.Name;
                _description3.text = actividad.Description;
                i++;
            }
            if (numActividad == 4)
            {
                optionsCanvas.transform.GetChild(0).GetChild(2).GetChild(0).GetChild(0).GetChild(i).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
                _tittle4.text = actividad.Name;
                _description4.text = actividad.Description;
                i++;
            }
            if (numActividad == 5)
            {
                optionsCanvas.transform.GetChild(0).GetChild(2).GetChild(0).GetChild(0).GetChild(i).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
                _tittle5.text = actividad.Name;
                _description5.text = actividad.Description;
                i++;
            }
            numActividad++;
        }

        optionsCanvas.transform.GetChild(0).GetChild(2).GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        optionsCanvas.transform.GetChild(0).GetChild(3).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        optionsCanvas.transform.GetChild(0).GetChild(4).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        descActivityCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

    }

    public void VolverLogin()
    {

        OnLogin?.Invoke();
        activitiesIds.Clear();     
    }

    int idActividadSeleccionada;
    int activity;

    public void Act1Aux0()
    {
        activity = 0;
        idActividadSeleccionada = activitiesIds[activity];
        StartCoroutine("CollectActivity2UserByActivityId");
        StartCoroutine("CollectStepByActivtyId");
    }
    public void Act1Aux1()
    {
        activity = 1;
        idActividadSeleccionada = activitiesIds[activity];
        StartCoroutine("CollectActivity2UserByActivityId");
        StartCoroutine("CollectStepByActivtyId");
    }
    public void Act1Aux2()
    {
        activity = 2;
        idActividadSeleccionada = activitiesIds[activity];
        StartCoroutine("CollectActivity2UserByActivityId");
        StartCoroutine("CollectStepByActivtyId");
    }
    public void Act1Aux3()
    {
        activity = 3;
        idActividadSeleccionada = activitiesIds[activity];
        StartCoroutine("CollectActivity2UserByActivityId");
        StartCoroutine("CollectStepByActivtyId");
    }
    public void Act1Aux4()
    {
        activity = 4;
        idActividadSeleccionada = activitiesIds[activity];
        StartCoroutine("CollectActivity2UserByActivityId");
        StartCoroutine("CollectStepByActivtyId");
    }
    public void Act1Aux5()
    {
        activity = 5;
        idActividadSeleccionada = activitiesIds[activity];
        StartCoroutine("CollectActivity2UserByActivityId");
        StartCoroutine("CollectStepByActivtyId");
    }

    public void InfoActivityComplete() {

        StopCoroutine("CollectActivity2UserByActivityId");
        StopCoroutine("CollectStepByActivtyId");

        nameAct.text = activitiesByOwner[activity].Name;
        descAct.text = activitiesByOwner[activity].Description;

        for (int x = 0; x < usuarios.Count; x++)
        {
            if (x == 0)
            {
                pacienteAct.text = usuarios[x];           
            }
            else
            {
                pacienteAct.text = pacienteAct.text + "\n" + usuarios[x];
            }
        }

        int numStep = 0;
        int aux = 1;
        foreach (var s in step)
        {
            if (numStep == 0)
            {   
                if(s.stepDescriptions[0].Description == "string")
                {
                    pasosAct.text = "Paso 1 --> No hay descripcion";
                }
                else
                {
                    pasosAct.text = "Paso 1 --> " + s.stepDescriptions[0].Description;
                }
            }
            else
            {
                if (s.stepDescriptions[0].Description == "string")
                {
                    pasosAct.text = pasosAct.text + "\nPaso " + aux + " --> No hay descripcion"  ;
                }
                else
                {   
                    pasosAct.text = pasosAct.text + "\nPaso " + aux +" --> " +s.stepDescriptions[0].Description;
                }
            }
            aux++;
            numStep++;
        }

        onDescActivity?.Invoke();
    }

    public void VolverOptions()
    {
        step.Clear();
        usuarios.Clear();
        ActivateOptionsMenu();
    }


    public void AsistenteInfoMenu()
    {
        nameActInfo.text = activitiesByOwner[activity].Name;
        onAsistenteInfo?.Invoke();
        Debug.Log("Asistente Info menu ACTIVATED");
    }

    public void AsistenteStartPasoAux()
    {
        if(stepAux < stepsIds.Count())
        {
            StartCoroutine("GetStepsById");
            stepAux++ ;
        }
        else
        {
            Debug.Log("NO HAY MAS PASOS");
            EndActivityMenuControlador();
            //Llamar a no hay mas pasos
        }

    }

    public void AsistenteStartPasoMenu()
    {
        StopCoroutine("GetStepsById");

        namePaso1.text = activitiesByOwner[activity].Name;
        bocadilloNombreAct.text = activitiesByOwner[activity].Name;
        bocadilloPrimerPaso.text = stepInformation.stepDescriptions[0].Description;
        bocadilloNombreUbicacion.text = stepInformation.InteractiveSpaceName;
        bocadilloObjetosPaso1.text = stepInformation.stepDescriptions[0].entities[0].entityName;

        onAsistenteStartPaso?.Invoke();
    }

    public void RegisterSpaceMenu()
    {
        if (regUbicacionAntigua != stepInformation.InteractiveSpaceName)
        {
            regUbicacionAntigua = stepInformation.InteractiveSpaceName;

            onRegisterSpace?.Invoke();
            Debug.Log("Register Space menu ACTIVATED");
        }
        else
        {
            BoxObjetosOpenMenu();
        }
    }

    public void BoxObjetosOpenMenu()
    {

        objetoAColocar.text = stepInformation.stepDescriptions[0].entities[0].entityName;

        onBoxObjetosOpen?.Invoke();
        Debug.Log("Box Objetos Open menu ACTIVATED");
    }

    public void ARPositionObjectMenu()
    {
        onARPositionObject?.Invoke();
        Debug.Log("AR Position Object menu ACTIVATED");
    }

    public void AsistenteInfoSaveMenuPaso()
    {

        bocadilloSavePaso.text = stepInformation.stepDescriptions[0].Description;
        actividadName.text = activitiesByOwner[activity].Name;

        Debug.Log("GUARDAR?");
        onAsistenteInfoSave?.Invoke();
    }

    public void NextPasoMenuControlador()
    {
        actNamee.text = activitiesByOwner[activity].Name;
        onNextPaso?.Invoke();
    }

    public void EndActivityMenuControlador()
    {
        bocadilloNombreActFin.text = activitiesByOwner[activity].Name;
        actFinName.text = activitiesByOwner[activity].Name;

        onEndActivity?.Invoke();
    }

    public void SalirEditActivity()
    {

        stepAux = 0;
        stepsIds.Clear();
        step.Clear();
        regUbicacionAntigua = null;

        StartCoroutine("CollectActivitiesByOwner");
    }

    public void CloseApp()
    {
        Application.Quit();
    }





    public void ItemsMenu()
    {
        OnItemsMenu?.Invoke();
        Debug.Log("Item menu ACTIVATED");
    }
    public void ARPosition()
    {
        OnARPosition?.Invoke();
        Debug.Log("AR Position ACTIVATED");
    }



    

}

