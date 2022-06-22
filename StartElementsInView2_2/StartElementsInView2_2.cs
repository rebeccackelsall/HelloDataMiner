using Skyline.DataMiner.Automation;

public class Script
{
	public void Run(IEngine engine)
	{
		var elements = engine.FindElementsInView("Workshop CI/CD");
		
		foreach (var element in elements)
		{
			if (!element.IsActive)
			{
				engine.GenerateInformation($"Starting element: {element.ElementName}");
				element.Start();
			}
		}
	}
}