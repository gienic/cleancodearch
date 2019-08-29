
//In PluginConfiguration unter this.ReadAllowedAttachments(reader) im Konstructor

this.ReadSupportedContainer(reader)

// Neue Funtion unter die Funktion ReadAllowedAttachments

internal void ReadSupportedContainer(IConfigurationReader reader)
{
  // TODO: richtig auslesen
  // <Compressed>Wert<Compressed>
  string compressed = reader.GetStringValue("SupportedCntainer.Compressed")
  string mime = reader.GetStringValue("SupportedCntainer.Mime")
  
  string[] compressed_items = compressed.Split(' ');  
  List<string> compressed_list = new List<string>(compressed_items);
  
  string[] mime_items = mime.Split(' ');  
  List<string> mime_list = new List<string>(mime_items);
 
  this.SupportedContainerCompressed = compressed_list;
  this.SupportedContainerMime = mime_list;
  
}

// In IPluginConfiguration unter List<IAttachments> AllowedAttachments 

List<string> SupportedContainerCompressed {}
List<string> SupportedContainerMime {}


