echo "Composing infrastructure"
docker-compose up -d --force-recreate --build
sleep 10

STATUS=$(exec docker ps -a --filter "name=pokedexwebapi_webapi_1" --format '{{.Status}}')
while [[ $STATUS == *"Exited"* ]]; do
	echo "Starting"
	docker start pokedexwebapi_webapi_1
	sleep 2
	STATUS=$(exec docker ps -a --filter "name=pokedexwebapi_webapi_1" --format '{{.Status}}')
done

echo "Start finished"
echo " "
echo "    APP READY TO USE. HAVE A NICE DAY      "
echo "                    ##        .            "
echo "              ## ## ##       ==            "
echo "           ## ## ## ##      ===            "
echo "       /\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\\\___/ ===        "
echo "  ~~~ {~~ ~~~~ ~~~ ~~~~ ~~ ~ /  ===- ~~~   "
echo "       \\\______ o          __/            "
echo "         \\\    \\\        __/             "
echo "          \\\____\\\______/                "
echo "                                           "
echo "          |          |                     "
echo "       __ |  __   __ | _  __   _           "
echo "      /  \\\| /  \\\ /   |/  / _\\\ |      "
echo "      \\\__/| \\\__/ \\\__ |\\\_ \\\__  |  "
echo " "