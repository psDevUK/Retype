BeforeAll {
      Import-Module .\Retype\Retype.psd1
}

Describe 'Install-Retype' {
      It 'Makes sure Retype has installed' {
            $AddRetype = ';D:\a\Retype\Retype\Retype'
            $Environment = [System.Environment]::GetEnvironmentVariable('Path', 'Machine')
            $Environment = $Environment.Insert($Environment.Length, $AddRetype)
            [System.Environment]::SetEnvironmentVariable('Path', $Environment, 'Machine')
            Install-Retype
            $env:Path -match 'Retype' | Should -Be $true
      }
}
