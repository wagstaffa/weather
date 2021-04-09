node('DOTNETCORE'){
	stage('SCM'){
		checkout([$class: 'GitSCM', branches: [[name: '*/master']], doGenerateSubmoduleConfigurations: false, extensions: [], submoduleCfg: [], userRemoteConfigs: [[url: 'https://github.com/wagstaffa/weather']]])
	}
	stage('Restore'){
		sh 'dotnet restore'
	}
	stage('Build'){
		try{
		sh 'dotnet build Weather'
		}finally{
		archiveArtifacts artifacts: 'Weather/*.*'
		}
	}
	stage('Test'){
		echo 'Execute unit tests'
		sh 'dotnet test'
	}
	stage('Publish'){
		echo 'Publish to dir: publish'
		sh 'dotnet publish -c=Release -o=publish'
	}
	stage('Deploy'){
		echo 'Push to deployment'
	}
	stage('Archive'){
		archiveArtifacts artifacts: 'publish/*.*'
	}
}