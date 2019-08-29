
//In PluginConfiguration unter this.ReadAllowedAttachments(reader) im Konstructor einfügen

this.ReadSupportedContainer(reader)

// Neue Funtion unter die Funktion ReadAllowedAttachments einfügen

internal void ReadSupportedContainer(IConfigurationReader reader)
{
  this.SupportedContainerCompressed = new List<string>;
  this.SupportedContainerMime = new List<string>;
  
  foreach(string element in reader.GetChildElements("SupportedCntainer.Compressed"))
  {
    this.SupportedContainerCompressed.Add(reader.GetStringValue("Extension"));
  }
  
  foreach(string element in reader.GetChildElements("SupportedCntainer.Mime"))
  {
    this.SupportedContainerMime.Add(reader.GetStringValue("Extension"));
  }
 
}

// In IPluginConfiguration unter List<IAttachments> AllowedAttachments einfügen
 
List<string> SupportedContainerCompressed {}
List<string> SupportedContainerMime {}

// neu

List<string> compressedContainers = this.PluginConfiguration.SupportedContainerCompressed;
List<string> mailContainers = this.PluginConfiguration.SupportedContainerMime;

