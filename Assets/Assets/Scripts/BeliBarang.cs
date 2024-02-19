using UnityEngine;

public class BeliBarang : MonoBehaviour
{
    public GameObject CPUSultan;
    public GameObject CPUBiasa;
    public GameObject MonitorSultan;
    public GameObject MonitorBiasa;
    public GameObject MouseSultan;
    public GameObject MouseBiasa;
    public GameObject KeyboardSultan;
    public GameObject KeyboardBiasa;
    public GameObject MejaSultan;
    public GameObject MejaBiasa;
    public GameObject KursiSultan;
    public GameObject KursiBiasa;

    public void CPUSultans()
    {
        SpawnCPUSultan(0,0,0);
    }

    public void MonitorSultans()
    {
        SpawnMonitorSultan(0,0,0);
    }

    public void KeyboardSultans()
    {
        SpawnKeyboardSultan(0,0,0);
    }

    public void MouseSultans()
    {
        SpawnMouseSultan(0,0,0);
    }

    public void MejaSultans()
    {
        SpawnMejaSultan(0,0,0);
    }

    public void KursiSultans()
    {
        SpawnKursiSultan(0,0,0);
    }

    public void CPUBiasas()
    {
        SpawnCPUBiasa(0,0,0);
    }

    public void KeyboardBiasas()
    {
        SpawnKeyboardBiasa(0,0,0);
    }

    public void MonitorBiasas()
    {
        SpawnMonitorBiasa(0,0,0);
    }

    public void MouseBiasas()
    {
        SpawnMouseBiasa(0,0,0);
    }

    public void KursiBiasas()
    {
        SpawnKursiBiasa(0,0,0);
    }

    public void MejaBiasas()
    {
        SpawnMejaBiasa(0,0,0);
    }
    // Update is called once per frame
    private void SpawnCPUSultan(float posX, float posY, float posZ)
    {
        GameObject CPUS;
        CPUS = Instantiate(CPUSultan, new Vector3(posX, posY, posZ), transform.rotation);
        CPUS.transform.SetParent(GameObject.Find("KPC").transform, false);
    }

    private void SpawnCPUBiasa(float posX, float posY, float posZ)
    {
        GameObject CPUB;
        CPUB = Instantiate(CPUBiasa, new Vector3(posX, posY, posZ), transform.rotation);
        CPUB.transform.SetParent(GameObject.Find("KPC").transform, false);
    }

    private void SpawnMonitorBiasa(float posX, float posY, float posZ)
    {
        GameObject MonB;
        MonB = Instantiate(MonitorBiasa, new Vector3(posX, posY, posZ), transform.rotation);
        MonB.transform.SetParent(GameObject.Find("KPC").transform, false);
    }

    private void SpawnMonitorSultan(float posX, float posY, float posZ)
    {
        GameObject MonS;
        MonS = Instantiate(MonitorSultan, new Vector3(posX, posY, posZ), transform.rotation);
        MonS.transform.SetParent(GameObject.Find("KPC").transform, false);
    }

    private void SpawnMouseBiasa(float posX, float posY, float posZ)
    {
        GameObject MOB;
        MOB = Instantiate(MouseBiasa, new Vector3(posX, posY, posZ), transform.rotation);
        MOB.transform.SetParent(GameObject.Find("KPC").transform, false);
    }

    private void SpawnMouseSultan(float posX, float posY, float posZ)
    {
        GameObject MOS;
        MOS = Instantiate(MouseSultan, new Vector3(posX, posY, posZ), transform.rotation);
        MOS.transform.SetParent(GameObject.Find("KPC").transform, false);
    }

    private void SpawnKeyboardBiasa(float posX, float posY, float posZ)
    {
        GameObject KeB;
        KeB = Instantiate(KeyboardBiasa, new Vector3(posX, posY, posZ), transform.rotation);
        KeB.transform.SetParent(GameObject.Find("KPC").transform, false);
    }

    private void SpawnKeyboardSultan(float posX, float posY, float posZ)
    {
        GameObject KeS;
        KeS = Instantiate(KeyboardSultan, new Vector3(posX, posY, posZ), transform.rotation);
        KeS.transform.SetParent(GameObject.Find("KPC").transform, false);
    }

    private void SpawnMejaBiasa(float posX, float posY, float posZ)
    {
        GameObject MB;
        MB = Instantiate(MejaBiasa, new Vector3(posX, posY, posZ), transform.rotation);
        MB.transform.SetParent(GameObject.Find("KPC").transform, false);
    }

    private void SpawnMejaSultan(float posX, float posY, float posZ)
    {
        GameObject MS;
        MS = Instantiate(MejaSultan, new Vector3(posX, posY, posZ), transform.rotation);
        MS.transform.SetParent(GameObject.Find("KPC").transform, false);
    }

    private void SpawnKursiBiasa(float posX, float posY, float posZ)
    {
        GameObject KB;
        KB = Instantiate(KursiBiasa, new Vector3(posX, posY, posZ), transform.rotation);
        KB.transform.SetParent(GameObject.Find("KPC").transform, false);
    }

    private void SpawnKursiSultan(float posX, float posY, float posZ)
    {
        GameObject KS;
        KS = Instantiate(KursiSultan, new Vector3(posX, posY, posZ), transform.rotation);
        KS.transform.SetParent(GameObject.Find("KPC").transform, false);
    }
}
