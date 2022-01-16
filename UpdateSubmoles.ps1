

$submodules = @('Distro.Seedworks.Infrastructure','Distro.Domain.Common')

foreach ($submodule in $submodules)
{
    $path = "$(Get-Location)\$submodule"

    if (-not (Test-Path -Path $path))
    {
        # Throw an exception when the fodler does not exist (Should be there at the very least)
        throw "Invalid state exception! Missing submodule folder ($path), please investigate."
    }
   
    # Check if the submodule have been initialized
    if (-not [System.IO.File]::Exists("$path\.git"))
    {
        ## Checkout and initatlize submodule
        git submodule init
        git submodule update
        git checkout main # assuming submodules only have main
    }

    git pull
}
