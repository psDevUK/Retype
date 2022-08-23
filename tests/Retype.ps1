BeforeAll {
      Import-Module ./YoutubeDownloader/YoutubeDownloader.psd1
}

Describe 'Save-YoutubeVideo' {
      It 'Returns all expected properties' {
            $null = Save-YoutubeVideo -URL "https://www.youtube.com/watch?v=0EqSXDwTq6U" -Path /tmp/
            $video = Get-ChildItem -Path /tmp/ -Filter *.mp4 | Sort-Object LastWriteTime -Descending | Select-Object -First 1
            $video.FullName | Should -Be "/tmp/Charlie bit my finger! ORIGINAL.mp4"
            $video.Length | Should -BeGreaterThan 0
      }
}
