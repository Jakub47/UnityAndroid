using UnityEditor;
public class FBXFix : AssetPostprocessor 
{
	public void OnPreprocessModel()
	{
		ModelImporter modelImporter = (ModelImporter) assetImporter;
		modelImporter.globalScale = 1;
	}
}
