using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class ReceptionistScript : MonoBehaviour
{
    [Header("受付嬢のセリフ追加リスト"), SerializeField]
    private List<string> _receptionistLines = new List<string>();

    [Header("表示先テキスト"), SerializeField]
    private TextMeshProUGUI _lineText;

    [Header("セリフボタン"), SerializeField]
    private Button _lineButton;

    [Header("受付嬢接触判定"), SerializeField]
    private Button _receptionistButton;

    private void Awake()
    {
        // セリフボタンのリスナー登録
        if (_lineButton != null)
        {
            _lineButton.onClick.AddListener(OnClickAddReceptionistLineButton);
            _receptionistButton.onClick.AddListener(OnClickAddReceptionistLineButton);
        }
        else
        {
            Debug.LogWarning("ReceptionistScript: _lineButton が Inspector にセットされていません。");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // 初期表示が必要ならここで設定できます
        if (_lineText != null && _receptionistLines.Count > 0)
        {
            _lineText.text = _receptionistLines[0];
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnClickAddReceptionistLineButton()
    {
        // ランダムにセリフを選んで表示
        if (_lineText == null)
        {
            Debug.LogWarning("ReceptionistScript: _lineText が Inspector にセットされていません。");
            return;
        }

        // セリフリストが空の場合の処理
        if (_receptionistLines == null || _receptionistLines.Count == 0)
        {
            _lineText.text = "（セリフが登録されていません）";
            return;
        }

        // ランダムにインデックスを選択してセリフを表示
        int index = Random.Range(0, _receptionistLines.Count); // min inclusive, max exclusive
        _lineText.text = _receptionistLines[index];
    }
}