echo "Composing infrastructure"
docker-compose up -d --force-recreate --build
sleep 5

echo "Start Migrations"
docker start pokedexwebapi_migrator_1

STATUS=$(exec docker ps -a --filter "name=pokedexwebapi_migrator_1" --format '{{.Status}}')
while [[ $STATUS != *"Exited"* ]]; do
	echo $STATUS "migrating"
	sleep 1
	STATUS=$(exec docker ps -a --filter "name=pokedexwebapi_migrator_1" --format '{{.Status}}')
done

echo "Migration finished"
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