node('DOTNETCORE'){
	stage('SCM'){
		checkout([$class: 'GitSCM', branches: [[name: '*/master']], extensions: [], userRemoteConfigs: [[url: 'https://github.com/wagstaffa/weather']]])
	}
	stage('Build'){
		try{
		sh 'dotnet build Weather/Weather'
		}finally{
		archiveArtifacts artifacts: 'Weather/Weather/*.*'
		}
	}
	stage('Test'){
		echo 'Execute unit tests'
	}
	stage('Package'){
		echo 'Zip it up'
	}
	stage('Deploy'){
		echo 'Push to deployment'
	}
	stage('Archive'){
		archiveArtifacts artifacts: 'Weather/Weather/*.*'
	}
}