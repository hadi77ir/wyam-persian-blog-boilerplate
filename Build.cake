#addin "Cake.Npm"
#addin "nuget:?package=Cake.Wyam"
#tool "nuget:?package=Wyam"

var target = Argument("target", "Build");

Task("Build")
    .Does(() =>
    {
		Wyam();        
    });

Task("Preview")
    .Does(() =>
    {
        Wyam(new WyamSettings
        {
            Preview = true,
            Watch = true
        });        
    });

RunTarget(target);
