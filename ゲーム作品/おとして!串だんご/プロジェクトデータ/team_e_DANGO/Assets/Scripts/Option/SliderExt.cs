using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SliderExt : MonoBehaviour, IPointerUpHandler
{
    Slider slider;

    SoundManager soundManager;

    private void Start()
    {
        slider = GetComponent<Slider>();
        soundManager = SoundManager.Instance;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        soundManager.seManager.PlayOneShot(soundManager.decide);
    }
}