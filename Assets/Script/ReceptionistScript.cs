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

    [Header("勝利したときの受付嬢のセリフ追加リスト"), SerializeField]
    private List<string> _victoryLines = new List<string>();

    [Header("敗北したときの受付嬢のセリフ追加リスト"), SerializeField]
    private List<string> _defeatLines = new List<string>();

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
        // _lineText が null の場合の処理        
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

    // ランダムなセリフを表示するメソッド（将来の拡張用）
    public void ShowRandomLine()
    {
        // _lineText が null の場合の処理        
        if (_lineText == null)
        {
            Debug.LogWarning("ReceptionistScript: _lineText が Inspector にセットされていません。");
            return;
        }

        // セリフリストが空の場合の処理
        if (_victoryLines == null || _victoryLines.Count == 0)
        {
            _lineText.text = "（セリフが登録されていません）";
            return;
        }
        int index = Random.Range(0, _victoryLines.Count);
        _lineText.text = _victoryLines[index];
    }

    public void ShowDefeatLine()
    {
        // _lineText が null の場合の処理        
        if (_lineText == null)
        {
            Debug.LogWarning("ReceptionistScript: _lineText が Inspector にセットされていません。");
            return;
        }

        // セリフリストが空の場合の処理
        if (_defeatLines == null || _defeatLines.Count == 0)
        {
            _lineText.text = "（セリフが登録されていません）";
            return;
        }

        int index = Random.Range(0, _defeatLines.Count);
        _lineText.text = _defeatLines[index];
    }
}