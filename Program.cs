using NLog;
using System.ComponentModel.Design.Serialization;
using System.Text.Json;

string path = Directory.GetCurrentDirectory() + "//nlog.config";

var logger = LogManager.Setup().LoadConfigurationFromFile(path).GetCurrentClassLogger();

logger.Info("Program started");

string marioFileName = "mario.json";
List<Mario> marios = JsonSerializer.Deserialize<List<Mario>>(File.ReadAllText(marioFileName))!;

logger.Info("Program ended");