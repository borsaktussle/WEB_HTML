<html>
  <head>
    <title>Blank Table-Based Grid</title>
    <script src="https://chemwriter.com/sdk/chemwriter.js"></script>
    <link rel="stylesheet" href="https://chemwriter.com/sdk/chemwriter.css">
  </head>
  <style>
    body { font-family: monospace; }
    h1 { border-bottom: 4px solid black; font-size: 260%; }
    table { width: 100%; border-collapse: collapse; border-style: hidden; table-layout: fixed; }
    td { border: 10px solid transparent; }
    tr { height: 200px; }
    .page { width: 930px; margin: 0 auto; }
    .cell { background-color: #c0c0c0; text-align: center; padding: 10px; }
    .image { height: 100px; background-color: white; margin-bottom: 10px;}
    .data { font-size: 180%; }
  </style>
  <body>
    <div class="page">
      <h1>Results</h1>
      <table>
        <tbody>
          <tr>
            <td>
              <div class="cell">
                <div class="image"><div data-chemwriter-ui="image" data-chemwriter-src="http://chemwriter.com/data/structure-2.mol"></div></div>
                <div class="data">Data</div>
              </div>
            </td>
            <td>
              <div class="cell">
                <div class="image"><div data-chemwriter-ui="image" data-chemwriter-src="http://chemwriter.com/data/structure-3.mol"></div></div>
                <div class="data">Data</div>
              </div>
            </td>
            <td>
              <div class="cell">
                <div class="image"><div data-chemwriter-ui="image" data-chemwriter-src="http://chemwriter.com/data/structure-4.mol"></div></div>
                <div class="data">Data</div>
              </div>
            </td>
            <td>
              <div class="cell">
                <div class="image"><div data-chemwriter-ui="image" data-chemwriter-src="http://chemwriter.com/data/structure-5.mol"></div></div>
                <div class="data">Data</div>
              </div>
            </td>
            <td>
              <div class="cell">
                <div class="image"><div data-chemwriter-ui="image" data-chemwriter-src="http://chemwriter.com/data/structure-6.mol"></div></div>
                <div class="data">Data</div>
              </div>
            </td>
          </tr>
        </tbody>
      </table>
    </div>
  </body>
</html>