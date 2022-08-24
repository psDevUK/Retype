Function Install-Retype {
    Write-Host "Checking for elevated permissions..."
    if (-NOT ([Security.Principal.WindowsPrincipal] [Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole(`
                [Security.Principal.WindowsBuiltInRole] "Administrator")) {
        Write-Warning "Insufficient permissions to run this script. Open the PowerShell console as an administrator and run this script again."
        Break
    }
    elseif (-not($env:Path -match 'Retype')) {
        Write-Host "Checking to see if Retype is in the System Environment Path variable..." -ForegroundColor Green
        Write-Host 'Retype not installed I will now fix this'
        $Environment = [System.Environment]::GetEnvironmentVariable('Path', 'Machine')
        $installed = $env:PSModulePath -split ';' | % {if(Test-path $_\Retype){$_}}
        if ($installed.length -lt 1){Write-Host 'I cannot find the Retype module in any module path, please manually add the path to system environment path';break}
        Write-Host 'I found Retype installed at $(installed)'
        Write-Host 'I will now add ;$($installed)\Retype to environment path'
        $AddRetype = ';$($installed)\Retype'
        $Environment = $Environment.Insert($Environment.Length, $AddRetype)
        [System.Environment]::SetEnvironmentVariable('Path', $Environment, 'Machine')
    }
    else {
        Write-Host "It appears you have the Retype added to the System Environment variable path. Go make a great website..."
    }
}
