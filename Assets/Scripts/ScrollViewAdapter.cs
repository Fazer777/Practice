using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollViewAdapter : MonoBehaviour
{
    public RectTransform prefab;
    public RectTransform content;
    public Sprite[] images;

    public class TestItemView
    {
        public Image image;
        public Button button;

        public TestItemView(Transform rootView)
        { // Поменять тестовые значения в соответствии с названиями компонентов
            image = rootView.Find("Image").GetComponent<Image>();
            button = rootView.Find("Button").GetComponent<Button>();
        }

    }

    public class TestItemModel
    {
        public Sprite image;
        public string buttonText;
    }

    public void UpdateItems()
    {
        int countModel = images.Length;
       OnReceivedModels(GetItems(countModel));
    }

    void OnReceivedModels(TestItemModel[] models)
    {
        foreach (Transform i in content)
        {
            Destroy(i.gameObject);
        }

        foreach (var model in models)
        {
            var instance = GameObject.Instantiate(prefab.gameObject) as GameObject;
            instance.transform.SetParent(content, false);
            InitializeItemView(instance, model);
        }
    }

    void InitializeItemView(GameObject viewGameObject, TestItemModel model)
    {
        TestItemView view = new TestItemView(viewGameObject.transform);
        view.image.sprite = model.image;
        view.button.GetComponentInChildren<Text>().text = model.buttonText;
    }


    private TestItemModel[] GetItems(int countModels)
    {
        var results = new TestItemModel[countModels];
        for (int i = 0; i < countModels; i++)
        {
            results[i] = new TestItemModel();
            results[i].image = images[i];
            results[i].buttonText = "Click";
        }

        return results;
    }

    
}
