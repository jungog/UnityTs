using UnityEngine;
using Puerts;

public class test : MonoBehaviour
{
    JsEnv jsEnv;
    // Start is called before the first frame update
    void Start()
    {
        jsEnv = new JsEnv(new DefaultLoader(), 8282);
        jsEnv.Eval("require('test')");
    }

    // Update is called once per frame
    void Update()
    {
        jsEnv.Tick();
    }

    void OnDestroy()
    {
        jsEnv.Dispose();
    }
}
