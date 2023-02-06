//How needed set Name for Threads?

File.Delete("MainFile.json");

int filesCount = Directory.GetFiles("Files", "*", SearchOption.AllDirectories).Length;
int fileNumber = 0;
string dataFromFiles = "";
Thread[] threads = new Thread[filesCount];
Thread thread = new Thread(ReadFromFiles);

for (int i = 0; i < filesCount; i++)
{
    threads[i] = new Thread(ReadFromFile);
}

thread.Start();


//=============================================================//
void ReadFromFiles()
{
    for (int i = 0; i < filesCount; i++)
    {
        threads[i].Start();
        threads[i].Join();
    }
}

void ReadFromFile()
{
    dataFromFiles = File.ReadAllText($"Files\\File{fileNumber}.json");
    fileNumber++;
    File.AppendAllText("MainFile.json", dataFromFiles);
}

