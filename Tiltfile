k8s_yaml('k8s/webapp.yaml')
k8s_yaml('k8s/cluster-example.yaml')

docker_build('ghcr.io/leonardoce/test-webapp', '.')
k8s_resource("webapp", port_forwards=[8080])