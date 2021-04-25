


To build the single-stage dockerfile:
`docker build -f Docker/single-stage/Dockerfile -t hello-docker:single-stage .`

To build the multi-stage dockerfile:
`docker build -f Docker/multi-stage/Dockerfile -t hello-docker:multi-stage .`

Now inspect the to images to compare their sizes:
`docker inspect hello-docker:single-stage` and
`docker inspect hello-docker:multi-stage`